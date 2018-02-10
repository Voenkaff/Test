using Models.Socket;
using Services.Configuration;
using Services.Services.Implementations;

namespace Server.Listener.Handlers
{
    public class GetTestsHandler : ICommandHandler
    {
        private readonly StreamWrapperService _streamWrapperService;
        private readonly TestDirectoryService _testDirectoryService;

        public GetTestsHandler(StreamWrapperService streamWrapperService)
        {
            _streamWrapperService = streamWrapperService;
            _testDirectoryService = new TestDirectoryService(ConfigContainer.GetConfig<ServerConfig>().TestFolder);
        }

        public void Handle(Command command)
        {
            var tests = _testDirectoryService.GetTests(command.Args);
            _streamWrapperService.SendObject(tests);
        }
    }
}