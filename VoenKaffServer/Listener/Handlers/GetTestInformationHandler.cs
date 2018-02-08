using Models.Socket;
using Services;
using Services.Services;

namespace VoenKaffServer.Listener.Handlers
{
    public class GetTestInformationHandler : ICommandHandler
    {
        private readonly IStreamWrapperService _streamWrapperService;
        private readonly ITestDirectoryService _testDirectoryService;

        public GetTestInformationHandler(IStreamWrapperService streamWrapperService)
        {
            _streamWrapperService = streamWrapperService;
            _testDirectoryService = new TestDirectoryService(Configuration.GetTestFolderPath());
        }

        public void Handle(Command command)
        {
            var testInformationObjects = _testDirectoryService.GetTestInformationObjects();
            _streamWrapperService.SendObject(testInformationObjects);
        }
    }
}