using Models.Socket;
using Services.Configuration;
using Services.Services.Implementations;
using Services.Services.Implementations.FileServices;

namespace Server.Listener.Handlers
{
    public class GetTestsHandler : ICommandHandler
    {
        private readonly StreamWrapperService _streamWrapperService;

        public GetTestsHandler(StreamWrapperService streamWrapperService)
        {
            _streamWrapperService = streamWrapperService;
        }



        public void Handle(Command command)
        {
            var saveFolder = ConfigContainer.GetConfig<ServerConfig>().SaveFolder;
            var testDevidedFileService = new TestDevidedFileService(saveFolder);
            var tests = testDevidedFileService.Load();
            _streamWrapperService.SendObject(tests);
        }
    }
}