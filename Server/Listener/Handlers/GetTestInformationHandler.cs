using Models.Socket;
using Services.Configuration;
using Services.Services;
using Services.Services.Implementations;

namespace Server.Listener.Handlers
{
    public class GetTestInformationHandler : ICommandHandler
    {
        private readonly IStreamWrapperService _streamWrapperService;
        private readonly ITestDirectoryService _testDirectoryService;

        public GetTestInformationHandler(IStreamWrapperService streamWrapperService)
        {
            _streamWrapperService = streamWrapperService;
            _testDirectoryService = new TestDirectoryService(ConfigContainer.GetConfig<ServerConfig>().TestFolder);
        }

        public void Handle(Command command)
        {
            var testInformationObjects = _testDirectoryService.GetTestInformationObjects();
            _streamWrapperService.SendObject(testInformationObjects);
        }
    }
}