using Models.Socket;
using Services.Configuration;
using Services.Services.Implementations;
using Services.Services.Implementations.FileServices;

namespace Server.Listener.Handlers
{
    public class GetImagesInformationHandler : ICommandHandler
    {
        private readonly StreamWrapperService _streamWrapperService;

        public GetImagesInformationHandler(StreamWrapperService streamWrapperService)
        {
            _streamWrapperService = streamWrapperService;
        }

        public void Handle(Command command)
        {
            var saveFolder = ConfigContainer.GetConfig<ServerConfig>().SaveFolder;
            var imageDevidedFileService = new ImageDevidedFileService(saveFolder);
            var informationObjects = imageDevidedFileService.GetInformationObjects();
            _streamWrapperService.SendObject(informationObjects);
        }
    }
}
