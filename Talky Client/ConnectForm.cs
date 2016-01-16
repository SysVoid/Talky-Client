using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Talky_Client.Connection;

namespace Talky_Client
{
    public partial class ConnectForm : Form
    {

        public static ConnectForm Instance { get; private set; }

        public ConnectForm()
        {
            InitializeComponent();
            Instance = this;
        }

        private bool ValidUsername(string desiredUsername)
        {
            return !(string.IsNullOrEmpty(desiredUsername) || string.IsNullOrWhiteSpace(desiredUsername) || desiredUsername.Length > 16 || desiredUsername.Contains("%") || desiredUsername.Contains("/") || desiredUsername.Contains("@") || desiredUsername.Contains("\\") || desiredUsername.Contains(";"));
        }

        private void _quitButton_Click(object sender, EventArgs e)
        {
            Instance = null;
            Environment.Exit(0);
        }

        private void _connectButton_Click(object sender, EventArgs e)
        {
            string host = _hostInput.Text;
            int port = 0;
            bool validPort = int.TryParse(_portInput.Text, out port);
            string username = _usernameInput.Text;

            if (string.IsNullOrEmpty(host) || string.IsNullOrWhiteSpace(host))
            {
                MessageBox.Show("Please correct the errors with the host field.", "Host");
                return;
            }

            if (string.IsNullOrEmpty(_portInput.Text) || !validPort)
            {
                MessageBox.Show("Please correct the errors with the port field.", "Port");
                return;
            }

            if (!ValidUsername(username))
            {
                MessageBox.Show("Please correct the errors with the username field.", "Username");
                return;
            }

            string password = "";
            if (!string.IsNullOrEmpty(_passwordInput.Text) && !string.IsNullOrWhiteSpace(_passwordInput.Text))
            {
                password = _passwordInput.Text;
            }

            ServerConnection connection = new ServerConnection(host, port, username, password);
            new ChatWindow().Show();
            Hide();
        }

        private void _hostInput_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_hostInput.Text) || string.IsNullOrWhiteSpace(_hostInput.Text))
            {
                _hostErrorImage.Visible = true;
            } else
            {
                _hostErrorImage.Visible = false;
            }
        }

        private void _portInput_TextChanged(object sender, EventArgs e)
        {
            int ignored;
            if (string.IsNullOrEmpty(_portInput.Text) || string.IsNullOrWhiteSpace(_portInput.Text) || !int.TryParse(_portInput.Text, out ignored))
            {
                _portErrorImage.Visible = true;
            } else
            {
                _portErrorImage.Visible = false;
            }
        }

        private void _usernameInput_TextChanged(object sender, EventArgs e)
        {
            if (!ValidUsername(_usernameInput.Text))
            {
                _usernameErrorImage.Visible = true;
            } else
            {
                _usernameErrorImage.Visible = false;
            }
        }

        private void ConnectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Instance = null;
            Environment.Exit(0);
        }

    }
}
