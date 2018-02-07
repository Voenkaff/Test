using Models.Socket;

namespace VoenKaffServer.Listener.Handlers
{
    public interface ICommandHandler
    {
        void Handle(Command command);
    }
}
