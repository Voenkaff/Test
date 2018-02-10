using System.Collections.Generic;
using System.IO;
using Models.TransferObjects;
using Newtonsoft.Json;

namespace Client.Services.Implementations
{
    public class ClientTestFileService : IClientTestFileService
    {
        private readonly string _testDirectory;
        private readonly string _imageDirectory;

        public ClientTestFileService(string testPath, string imagePath)
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            _testDirectory = $"{currentDirectory}//{testPath}";
            _imageDirectory = $"{currentDirectory}//{imagePath}";
        }

        public void SaveTests(List<TestTransferObject> testTransferObjects)
        {
            PrepareDirectory(_testDirectory);

            foreach (var testTransferObject in testTransferObjects)
            {
                SaveTest(testTransferObject);
            }
        }

        public void SaveTest(TestTransferObject testTransferObject)
        {
            using (var stream = new StreamWriter($"{_testDirectory}//{testTransferObject.Name}"))
            {
                var json = JsonConvert.SerializeObject(testTransferObject.Test);
                stream.Write(json);
            }
        }

        public void SaveImages(List<ImageTransferObject> imageTransferObjects)
        {
            PrepareDirectory(_imageDirectory);

            foreach (var imageTransferObject in imageTransferObjects)
            {
                SaveImage(imageTransferObject);
            }
        }

        public void SaveImage(ImageTransferObject imageTransferObject)
        {
            using (var stream = new StreamWriter($"{_imageDirectory}//{imageTransferObject.Name}"))
            {
                stream.Write(imageTransferObject.Image);
            }
        }

        private static void PrepareDirectory(string path)
        {
            var directoryExists = Directory.Exists(path);

            if (directoryExists)
            {
                CleanDirectory(path);
            }
            else
            {
                Directory.CreateDirectory(path);
            }
        }

        private static void CleanDirectory(string path)
        {
            var dir = new DirectoryInfo(path);

            foreach (var fi in dir.GetFiles())
            {
                fi.Delete();
            }

            foreach (var di in dir.GetDirectories())
            {
                CleanDirectory(di.FullName);
                di.Delete();
            }
        }
    }
}