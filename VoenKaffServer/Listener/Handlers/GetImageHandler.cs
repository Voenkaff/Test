using Models.Socket;
using Services;
using Services.Services;
using Services.Services.Implementations;

namespace VoenKaffServer.Listener.Handlers
{
    public class GetImageHandler : ICommandHandler
    {
        private readonly IStreamWrapperService _streamWrapperService;
        private readonly ITestDirectoryService _testDirectoryService;

        public GetImageHandler(IStreamWrapperService streamWrapperService)
        {
            _streamWrapperService = streamWrapperService;
            _testDirectoryService = new TestDirectoryService(Configuration.GetTestFolderPath());
        }

        public void Handle(Command command)
        {
            var images = _testDirectoryService.GetImage(command.Args[0]);
            _streamWrapperService.SendObject(images);
        }
    }
}
