using System;
using System.Net.Sockets;
using System.Text;

namespace VoenKaffStartClient.Senders
{
    public class SocketService
    {
        private readonly string _ip;
        private readonly int _port;

        public SocketService(string ip, int port)
        {
            _ip = ip;
            _port = port;
        }

        public void SendText(string text)
        {
            var client = new TcpClient();
            client.Connect(_ip, _port);
            
            var stream = client.GetStream();

            var bytes = Encoding.UTF8.GetBytes(text);
            stream.Write(Encoding.UTF8.GetBytes(text), 0, bytes.Length);

            stream.Close();
            client.Close();
        }
    }
}