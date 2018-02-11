using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Server.Listener.Handlers;
using Services.Configuration;

namespace Server.Listener
{
    public class Listener
    {
        private readonly Thread _thread;

        public Listener()
        {
            _thread = new Thread(Listen)
            {
                IsBackground = true
            };
        }

        public void Start()
        {
            _thread.Start();
        }

        public void Interrupt()
        {
            _thread.Interrupt();
        }

        private static void Listen()
        {
            TcpListener listener = null;

            try
            {
                var config = ConfigContainer.GetConfig<ServerConfig>();
                
                listener = new TcpListener(IPAddress.Parse(config.ServerIp), config.ServerPort);
                
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
