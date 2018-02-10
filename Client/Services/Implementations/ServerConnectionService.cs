using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using Models;
using Models.Socket;
using Models.TransferObjects;
using Services.Services.Implementations;

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

        public bool IsConnected()
        {
            TcpClient client = null;

            try
            {
                client = new TcpClient();
                client.Connect(_ip, _port);
                return true;
            }
            catch (SocketException e)
            {
                return false;
            }
            finally
            {
                client?.Close();
            }
        }

        public List<InformationObject> GetTestInformationObjects()
        {
            return Get<List<InformationObject>>(Command.GetTestInformation());
        }

        public List<TestTransferObject> GetTests(List<InformationObject> testInformationObjects)
        {
            var testNames = testInformationObjects.Select(response => response.FileName).ToList();
            return Get<List<TestTransferObject>>(Command.Tests(testNames));
        }

        public List<InformationObject> GetImageInfromationObjects()
        {
            return Get<List<InformationObject>>(Command.GetImagesInfromation());
        }

        public List<ImageTransferObject> GetImages(List<InformationObject> informationObjects)
        {
            var commands = informationObjects.Select(i => Command.GetImages(i.FileName)).ToList();
            return Get<ImageTransferObject>(commands);
        }

        public List<Platoon> GetPlatoons()
        {
            return Get<List<Platoon>>(Command.GetSubjects());
        }

        public List<Subject> GetSubjects()
        {
            return Get<List<Subject>>(Command.GetSubjects());
        }

        public T Get<T>(Command command)
        {
            return Get<T>(new List<Command> {command})[0];
        }

        public List<T> Get<T>(List<Command> commands)
        {
            TcpClient client = null;
            NetworkStream stream = null;

            try
            {
                client = new TcpClient();
                client.Connect(_ip, _port);

                stream = client.GetStream();
                var streamWrapperService = new StreamWrapperService(stream);

                var result = new List<T>();

                foreach (var command in commands)
                {
                    streamWrapperService.SendCommand(command);
                    result.Add(streamWrapperService.ReciveObject<T>());
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