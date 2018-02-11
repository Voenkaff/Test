using Models.Socket;
using Services.Configuration;
using Services.Services;
using Services.Services.Implementations.FileServices;

namespace Server.Listener.Handlers
{
    public class GetTestInformationHandler : ICommandHandler
    {
        private readonly IStreamWrapperService _streamWrapperService;

        public GetTestInformationHandler(IStreamWrapperService streamWrapperService)
        {
            _streamWrapperService = streamWrapperService;
        }

        public void Handle(Command command)
        {
            var saveFolder = ConfigContainer.GetConfig<ServerConfig>().SaveFolder;
            var testDevidedFileService = new TestDevidedFileService(saveFolder);
            var testInformationObjects = testDevidedFileService.GetInformationObjects();
            _streamWrapperService.SendObject(testInformationObjects);
        }
    }
}