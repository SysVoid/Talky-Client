using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Talky_Client.Connection;
using System.Threading;

namespace Talky_Client
{
    public partial class ChatWindow : Form
    {

        private ServerConnection _connection { get; set; }
        private Thread _listeningThread { get; set; }

        public ChatWindow()
        {
            InitializeComponent();
        }

        private void ChatWindow_Shown(object sender, EventArgs e)
        {
            ServerConnection connection = ServerConnection.GetCurrentConnection();
            if (connection == null || connection.Client == null || !connection.Client.Connected)
            {
                MessageBox.Show("Could not connect to the Talky Chat Server!", "Connection Failure");
                _listeningThread = null;
                ServerConnection.SetCurrentConnection(null);
                ConnectForm.Instance.Show();
                Close();
                return;
            }

            _statusToolStripLabel.Text = "Connected";
            _connection = connection;

            _listeningThread = new Thread(new ThreadStart(Listen));
            _listeningThread.Name = "Message Listener Thread";
            _listeningThread.Start();
        }

        private void Listen()
        {
            string line = null;

            while (ServerConnection.GetCurrentConnection() != null && _connection.Client.Connected)
            {
                try
                {
                    line = _connection.Reader.ReadLine();
                } catch
                {
                    break;
                }

                if (string.IsNullOrEmpty(line))
                {
                    break;
                }

                if (line.StartsWith("M:"))
                {
                    _output.Invoke((MethodInvoker) delegate
                    {
                        _output.AppendText(line.Substring(2) + Environment.NewLine);
                    });
                } else if (line.StartsWith("S:ChannelList:"))
                {
                    string[] channels = line.Substring(14).Split(new char[] { ';' });
                    new ChannelList(channels).ShowDialog();
                } else if (line.StartsWith("S:Client:"))
                {
                    string[] data = line.Substring(9).Split(new char[] { ';' });
                    string username = data[0];
                    string muted = data[1];
                    string channel = data[2];

                    _usernameLabel.Invoke((MethodInvoker) delegate
                    {
                        _usernameLabel.Text = username;
                    });

                    _channelLabel.Invoke((MethodInvoker) delegate
                    {
                        _channelLabel.Text = channel;
                    });
                } else if (line.StartsWith("S:Account:"))
                {
                    string[] data = line.Substring(9).Split(new char[] { ';' });
                    string accountId = data[0];
                    string username = data[1];
                    string role = data[2];

                    _accountLabel.Invoke((MethodInvoker) delegate
                    {
                        _accountLabel.Visible = true;
                    });

                    _accountUsernameLabel.Invoke((MethodInvoker) delegate
                    {
                        _accountUsernameLabel.Visible = true;
                        _accountUsernameLabel.Text = username;
                    });

                    _accountRoleLabel.Invoke((MethodInvoker) delegate
                    {
                        _accountRoleLabel.Visible = true;
                        _accountRoleLabel.Text = role;
                    });
                }
            }

            _statusToolStripLabel.Text = "Connection Lost!";
            Thread.Sleep(1500);
            ConnectForm.Instance.Show();
            Close();
        }

        private void _channelListButton_Click(object sender, EventArgs e)
        {
            _connection.Writer.WriteLine("S:ChannelList");
            _connection.Writer.Flush();
        }

        private void ChatWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_connection != null && _connection.Client != null && _connection.Client.Connected)
            {
                _connection.Client.Close();
            }

            if (_listeningThread != null)
            {
                _listeningThread.Abort();
            }

            _listeningThread = null;
            ConnectForm.Instance.Show();
            ServerConnection.SetCurrentConnection(null);

            _accountLabel.Visible = true;
            _accountUsernameLabel.Visible = true;
            _accountRoleLabel.Visible = true;
        }

        private void _sendButton_Click(object sender, EventArgs e)
        {
            string message = _messageInput.Text;
            if (string.IsNullOrEmpty(message) || string.IsNullOrWhiteSpace(message))
            {
                return;
            }
            _connection.Writer.WriteLine("M:" + message);
            _connection.Writer.Flush();
            _connection.Writer.WriteLine("S:Client");
            _connection.Writer.Flush();
            _connection.Writer.WriteLine("S:Account");
            _connection.Writer.Flush();
            _messageInput.Text = "";
        }

        private void _disconnectButton_Click(object sender, EventArgs e)
        {
            ServerConnection.GetCurrentConnection().Client.Close();
            _listeningThread.Abort();
            _listeningThread = null;
            ServerConnection.SetCurrentConnection(null);
            ConnectForm.Instance.Show();
            Close();
        }

    }
}
