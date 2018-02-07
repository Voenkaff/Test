using Models.Socket;
using Services;

namespace VoenKaffServer.Listener.Handlers
{
    public class GetImagesInformationHandler : ICommandHandler
    {
        private readonly StreamWrapperService _streamWrapperService;
        private readonly TestDirectoryService _testDirectoryService;

        public GetImagesInformationHandler(StreamWrapperService streamWrapperService)
        {
            _streamWrapperService = streamWrapperService;
            _testDirectoryService = new TestDirectoryService(Configuration.GetTestFolderPath());
        }

        public void Handle(Command command)
        {
            var informationObjects = _testDirectoryService.GetImageInformationObjects();
            _streamWrapperService.SendObject(informationObjects);
        }
    }
}
