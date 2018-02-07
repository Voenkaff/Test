using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using Models.Socket;
using Models.TransferObjects;

namespace Services
{
    public class TcpClientSocketService
    {
        private readonly string _ip;
        private readonly int _port;

        public TcpClientSocketService(string ip, int port)
        {
            _ip = ip;
            _port = port;
        }

        public List<TestTransferObject> GetTests()
        {
            TcpClient client = null;
            NetworkStream stream = null;

            try
            {
                client = new TcpClient();
                client.Connect(_ip, _port);

                stream = client.GetStream();
                var streamWrapper = new StreamWrapperService(stream);

                streamWrapper.SendCommand(Command.Update());
                var responses = streamWrapper.ReciveInformationObjects();

                var testNames = responses.Select(response => response.FileName).ToList();

                streamWrapper.SendCommand(Command.Tests(testNames));
                var reciveTests = streamWrapper.ReciveTests();

                return reciveTests;
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }
            finally
            {
                stream?.Close();
                client?.Close();
            }

            return null;
        }

        public List<ImageTransferObject> GetImages()
        {
            TcpClient client = null;
            NetworkStream stream = null;

            try
            {
                client = new TcpClient();
                client.Connect(_ip, _port);

                stream = client.GetStream();
                var streamWrapperService = new StreamWrapperService(stream);

                streamWrapperService.SendCommand(Command.GetImagesInfromation());
                var informationObjects = streamWrapperService.ReciveInformationObjects();

                var result = new List<ImageTransferObject>();

                foreach (var informationObject in informationObjects)
                {
                    streamWrapperService.SendCommand(Command.GetImages(informationObject.FileName));
                    var recived = streamWrapperService.ReciveBytes();
                    result.Add(new ImageTransferObject
                    {
                        Name = informationObject.FileName,
                        Image = recived
                    });
                }

                return result;
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }
            finally
            {
                stream?.Close();
                client?.Close();
            }

            return null;
        }
    }
}