using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using VoenKaffServer.Listener.Handlers;

namespace VoenKaffServer.Listener
{
    public class Listener
    {
        private readonly DynamicParams _parameters;
        private readonly Thread _thread;

        public Listener()
        {
            _parameters = new DynamicParams();
            _thread = new Thread(Listen);
        }

        public void Start()
        {
            _thread.Start();
        }

        public void Interrupt()
        {
            _thread.Interrupt();
        }

        private void Listen()
        {
            TcpListener listener = null;

            try
            {
                var ip = _parameters.Get().IpAdress;
                var port = 8080;
                
                listener = new TcpListener(IPAddress.Parse(ip), port);
                
                listener.Start();

                while (true)
                {
                    var client = listener.AcceptTcpClient();

                    var connectionHandler = new ConnectionHandler(client);
                    var thread = new Thread(connectionHandler.Handle) {IsBackground = true};
                    thread.Start();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                listener?.Stop();
            } 
        }
    }
}
