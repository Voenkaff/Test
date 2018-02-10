using Models.Socket;
using Services.Configuration;
using Services.Services.Implementations;
using Services.Services.Implementations.FileServices;

namespace Server.Listener.Handlers
{
    public class GetSubjectsHandler : ICommandHandler
    {
        private readonly StreamWrapperService _streamWrapperService;
        private readonly SubjectFileService _subjectFileService;

        public GetSubjectsHandler(StreamWrapperService streamWrapperService)
        {
            _streamWrapperService = streamWrapperService;
            _subjectFileService = new SubjectFileService(ConfigContainer.GetConfig<ServerConfig>().SaveFolder);
        }

        public void Handle(Command command)
        {
            var subjects = _subjectFileService.Load();
            _streamWrapperService.SendObject(subjects);
        }
    }
}