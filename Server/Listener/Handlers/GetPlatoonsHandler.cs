using Models.Socket;
using Services.Configuration;
using Services.Services.Implementations;
using Services.Services.Implementations.FileServices;

namespace Server.Listener.Handlers
{
    public class GetPlatoonsHandler : ICommandHandler
    {
        private readonly StreamWrapperService _streamWrapperService;
        private readonly PlatoonFileService _platoonFileService;

        public GetPlatoonsHandler(StreamWrapperService streamWrapperService)
        {
            _streamWrapperService = streamWrapperService;
            _platoonFileService = new PlatoonFileService(ConfigContainer.GetConfig<ServerConfig>().SaveFolder);
        }

        public void Handle(Command command)
        {
            var subjects = _platoonFileService.Load();
            _streamWrapperService.SendObject(subjects);
        }
    }
}
