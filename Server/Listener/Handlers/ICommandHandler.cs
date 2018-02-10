using Models.Socket;

namespace Server.Listener.Handlers
{
    public interface ICommandHandler
    {
        void Handle(Command command);
    }
}
