using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using Models;
using Models.Socket;
using Models.TransferObjects;
using Services;

namespace Client.Services.Implementations
{
    public class ServerConnectionService : IServerConnectionService
    {
        private readonly string _ip;
        private readonly int _port;

        public ServerConnectionService(string ip, int port)
        {
            _ip = ip;
            _port = port;
        }

        public List<InformationObject> GetTestInformationObjects()
        {
            TcpClient client = null;
            NetworkStream stream = null;

            try
            {
                client = new TcpClient();
                client.Connect(_ip, _port);

                stream = client.GetStream();
                var streamWrapper = new StreamWrapperService(stream);

                streamWrapper.SendCommand(Command.GetTestInformation());
                return streamWrapper.ReciveInformationObjects().ToList();
            }
            finally
            {
                stream?.Close();
                client?.Close();
            }
        }

        public List<TestTransferObject> GetTests(List<InformationObject> testInformationObjects)
        {
            TcpClient client = null;
            NetworkStream stream = null;

            try
            {
                client = new TcpClient();
                client.Connect(_ip, _port);

                stream = client.GetStream();
                var streamWrapper = new StreamWrapperService(stream);


                var testNames = testInformationObjects.Select(response => response.FileName).ToList();

                streamWrapper.SendCommand(Command.Tests(testNames));
                var reciveTests = streamWrapper.ReciveTests();

                return reciveTests;
            }
            finally
            {
                stream?.Close();
                client?.Close();
            }
        }

        public List<InformationObject> GetImageInfromationObjects()
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

                return streamWrapperService.ReciveInformationObjects().ToList(); 
            }
            finally
            {
                stream?.Close();
                client?.Close();
            }
        }

        public List<ImageTransferObject> GetImages(List<InformationObject> informationObjects)
        {
            TcpClient client = null;
            NetworkStream stream = null;

            try
            {
                client = new TcpClient();
                client.Connect(_ip, _port);

                stream = client.GetStream();
                var streamWrapperService = new StreamWrapperService(stream);

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
            finally
            {
                stream?.Close();
                client?.Close();
            }
        }
    }
}