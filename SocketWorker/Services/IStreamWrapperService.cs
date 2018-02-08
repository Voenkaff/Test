using System.Collections.Generic;
using Models;
using Models.Socket;
using Models.TransferObjects;

namespace Services.Services
{
    public interface IStreamWrapperService
    {
        void SendCommand(Command command);
        void SendText(string text);
        void SendObject(object obj);
        IEnumerable<InformationObject> ReciveInformationObjects();
        string ReciveString();
        Command ReciveCommand();
        byte[] ReciveBytes();
        List<TestTransferObject> ReciveTests();
        TestContainer ReciveTest(string testName);
    }
}