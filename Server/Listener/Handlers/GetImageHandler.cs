using Models.Socket;
using Services.Configuration;
using Services.Services;
using Services.Services.Implementations;
using Services.Services.Implementations.FileServices;

namespace Server.Listener.Handlers
{
    public class GetImageHandler : ICommandHandler
    {
        private readonly IStreamWrapperService _streamWrapperService;

        public GetImageHandler(IStreamWrapperService streamWrapperService)
        {
            _streamWrapperService = streamWrapperService;
        }

        public void Handle(Command command)
        {
            var saveFolder = ConfigContainer.GetConfig<ServerConfig>().SaveFolder;
            var imageDevidedFileService = new ImageDevidedFileService(saveFolder);
            var images = imageDevidedFileService.Load(command.Args[0]);
            _streamWrapperService.SendObject(images);
        }
    }
}
