using System;
using System.IO;
using Newtonsoft.Json;
using Services;

namespace TCPTester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ReadKey();
            var socketService = new TcpClientSocketService("127.0.0.1", 8080);

            var tests = socketService.GetTests();
            var images = socketService.GetImages();

            var currentDirectory = Directory.GetCurrentDirectory();

            var testDirectory = $"{currentDirectory}//tests";
            var imageDirectory = $"{testDirectory}//images";

            if (Directory.Exists(testDirectory))
            {
                Directory.Delete(testDirectory);
            }

            Directory.CreateDirectory(testDirectory);
            Directory.CreateDirectory(imageDirectory);

            foreach (var testTransferObject in tests)
            {
                using (var stream =
                    new FileStream($"{testDirectory}//{testTransferObject.Name}", FileMode.OpenOrCreate))
                {
                    using (var writeStream = new StreamWriter(stream))
                    {
                        writeStream.Write(JsonConvert.SerializeObject(testTransferObject.TestContainer));
                    }
                }
            }

            foreach (var image in images)
            {
                using (var stream = new FileStream($"{imageDirectory}//{image.Name}", FileMode.OpenOrCreate))
                {
                    stream.Write(image.Image, 0, image.Image.Length);
                }
            }

            Console.ReadKey();
        }
    }
}