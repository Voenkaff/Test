using System.Collections.Generic;
using System.IO;
using System.Linq;
using Models;
using Models.TransferObjects;
using Newtonsoft.Json;
using Services.Services;

namespace Services
{
    public class TestDirectoryService : ITestDirectoryService
    {
        private readonly string _testDirectoryPath;

        public TestDirectoryService(string testDirectoryPath)
        {
            _testDirectoryPath = testDirectoryPath;
        }

        public List<TestContainer> GetTests()
        {
            var testFiles = GetAllTestFiles();
            return testFiles.Select(fileInfo => File.ReadAllText(fileInfo.FullName))
                .Select(JsonConvert.DeserializeObject<TestContainer>).ToList();
        }

        public List<TestTransferObject> GetTests(List<string> testNames)
        {
            var testFiles = GetAllTestFiles();
            var targetTest = testFiles.Where(info => testNames.Contains(info.Name));
            return targetTest.Select(fileInfo => new TestTransferObject
            {
                Name = fileInfo.Name,
                TestContainer = JsonConvert.DeserializeObject<TestContainer>(File.ReadAllText(fileInfo.FullName))
            }).ToList();
        }

        public List<InformationObject> GetTestInformationObjects()
        {
            var testFiles = GetAllTestFiles();

            var result = testFiles.Select(testFile => new InformationObject
                {
                    FileName = testFile.Name,
                    Type = ObjectType.Test,
                    LastUpdateTime = testFile.LastWriteTime
                })
                .ToList();

            return result;
        }

        public byte[] GetImage(string name)
        {
            var directoryInfo = new DirectoryInfo($"{_testDirectoryPath}\\picture");
            var fileInfo = directoryInfo.EnumerateFiles().FirstOrDefault(p => p.Name.Equals(name));

            return fileInfo == null ? null : File.ReadAllBytes(fileInfo.FullName);
        }

        public List<InformationObject> GetImageInformationObjects()
        {
            var directoryInfo = new DirectoryInfo($"{_testDirectoryPath}\\picture");

            return directoryInfo.EnumerateFiles()
                .Where(p => p.Extension.Equals(".bin"))
                .Select(fileInfo => new InformationObject
                {
                    FileName = fileInfo.Name,
                    LastUpdateTime = fileInfo.LastWriteTime,
                    Type = ObjectType.Picture
                })
                .ToList();
        }

        public IEnumerable<FileInfo> GetAllTestFiles()
        {
            var directoryInfo = new DirectoryInfo(_testDirectoryPath);
            return directoryInfo.EnumerateFiles().Where(file => file.Extension.Equals(".test"));
        }
    }
}