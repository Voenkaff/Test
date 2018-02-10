using System;
using System.Net.Sockets;
using Models.Socket;
using Services.Services.Implementations;

namespace Server.Listener.Handlers
{
    public class ConnectionHandler
    {
        private readonly TcpClient _client;

        public ConnectionHandler(TcpClient client)
        {
            _client = client;
        }

        public void Handle()
        {
            var stream = _client.GetStream();
            var streamWrapper = new StreamWrapperService(stream);
            while (true)
            {
                var command = streamWrapper.ReciveCommand();

                if (command == null)
                {
                    if (!stream.DataAvailable)
                    {
                        stream.Close();
                        _client.Close();
                        return;
                    }

                    continue;
                }

                switch (command.CommandType)
                {
                    case CommandType.GetTestInformation:
                        new GetTestInformationHandler(streamWrapper).Handle(command);
                        break;
                    case CommandType.GetTests:
                        new GetTestsHandler(streamWrapper).Handle(command);
                        break;
                    case CommandType.GetImage:
                        new GetImageHandler(streamWrapper).Handle(command);
                        break;
                    case CommandType.GetImagesInformation:
                        new GetImagesInformationHandler(streamWrapper).Handle(command);
                        break;
                    case CommandType.GetPlatoons:
                        new GetPlatoonsHandler(streamWrapper).Handle(command);
                        break;
                    case CommandType.GetSubjects:
                        new GetSubjectsHandler(streamWrapper).Handle(command);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}