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

namespace Talky_Client
{
    public partial class ChannelList : Form
    {

        private string[] _channels;

        public ChannelList(string[] channels)
        {
            InitializeComponent();
            _channels = channels;
        }

        private void ChannelList_Load(object sender, EventArgs e)
        {
            foreach (string channel in _channels)
            {
                _channelList.Items.Add(channel);
            }
        }

        private void _joinButton_Click(object sender, EventArgs e)
        {
            if (_channelList.SelectedItem != null && _channelList.SelectedItem is string)
            {
                ServerConnection _connection = ServerConnection.GetCurrentConnection();
                _connection.Writer.WriteLine("M:/join " + _channelList.SelectedItem);
                _connection.Writer.Flush();
                _connection.Writer.WriteLine("S:Client");
                _connection.Writer.Flush();
                Close();
            }
        }

    }
}
