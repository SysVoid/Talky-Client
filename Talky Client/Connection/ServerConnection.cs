using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;

namespace Talky_Client.Connection
{
    class ServerConnection
    {

        public string Host { get; set; }
        public int Port { get; set; }
        public string Username { get; set; }
        public TcpClient Client { get; private set; }
        public StreamReader Reader { get; private set; }
        public StreamWriter Writer { get; private set; }

        private static ServerConnection _currentConnection { get; set; }
        private static object _lock = new object();

        public ServerConnection(string host, int port, string username)
        {
            Host = host;
            Port = port;
            Username = username;
            _currentConnection = this;

            try
            {
                Client = new TcpClient(host, port);
                Reader = new StreamReader(Client.GetStream());
                Writer = new StreamWriter(Client.GetStream());

                Writer.WriteLine("M:/name " + username);
                Writer.Flush();

                Writer.WriteLine("S:Client");
                Writer.Flush();
            } catch
            {
                Client = null;
            }
        }

        public static ServerConnection GetCurrentConnection()
        {
            lock (_lock)
            {
                return _currentConnection;
            }
        }

        public static void SetCurrentConnection(ServerConnection connection)
        {
            lock (_lock)
            {
                _currentConnection = connection;
            }
        }

    }
}
