using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using Models;
using Models.Socket;
using Models.TransferObjects;
using Newtonsoft.Json;
using Services.Services;

namespace Services
{
    public class StreamWrapperService : IStreamWrapperService
    {
        private readonly NetworkStream _stream;

        public StreamWrapperService(NetworkStream stream)
        {
            _stream = stream;
        }

        public void SendCommand(Command command)
        {
            var jsonCommand = JsonConvert.SerializeObject(command);
            SendText(jsonCommand);
        }

        public void SendText(string text)
        {
            var updateTextBytes = Encoding.Unicode.GetBytes(text);
            _stream.Write(updateTextBytes, 0, updateTextBytes.Length);
        }

        public void SendObject(object obj)
        {
            var json = JsonConvert.SerializeObject(obj);
            SendText(json);
        }

        public IEnumerable<InformationObject> ReciveInformationObjects()
        {
            return JsonConvert.DeserializeObject<List<InformationObject>>(ReciveString());
        }

        public string ReciveString()
        {
            var reciveBytes = ReciveBytes();
            return Encoding.Unicode.GetString(reciveBytes, 0, reciveBytes.Length).Trim('\0');
        }

        public Command ReciveCommand()
        {
            var reciveString = ReciveString();
            return JsonConvert.DeserializeObject<Command>(reciveString);
        }

        public byte[] ReciveBytes()
        {
            var packets = new List<byte>();

            do
            {
                var data = new byte[256];
                _stream.Read(data, 0, data.Length);
                packets.AddRange(data);
            } while (_stream.DataAvailable);

            return packets.ToArray();
        }

        public List<TestTransferObject> ReciveTests()
        {
            var json = ReciveString();
            var tests = JsonConvert.DeserializeObject<List<TestTransferObject>>(json);
            return tests;
        }

        public Tests ReciveTest(string testName)
        {
            var json = ReciveString();
            return JsonConvert.DeserializeObject<Tests>(json);
        }

        public List<byte[]> ReciveImages()
        {
            var json = ReciveString();
            return JsonConvert.DeserializeObject<List<byte[]>>(json);
        }
    }
}