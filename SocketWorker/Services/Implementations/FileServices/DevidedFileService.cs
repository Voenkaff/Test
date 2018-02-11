using System.Collections.Generic;
using System.IO;
using System.Linq;
using Models;
using Newtonsoft.Json;

namespace Services.Services.Implementations.FileServices
{
    public class DevidedFileService<T>
    {
        private readonly List<string> _fileExtensions;
        private readonly ObjectType _objectType;
        private readonly string _directory;

        public DevidedFileService(string savePath, string directoryName, List<string> fileExtensions,
            ObjectType objectType)
        {
            _fileExtensions = fileExtensions;
            _objectType = objectType;
            _directory = Path.Combine(savePath, directoryName);
        }

        public void Update(List<FileUpdateAction<T>> fileUpdateActions)
        {
            if (!Directory.Exists(_directory))
            {
                Directory.CreateDirectory(_directory);
            }

            foreach (var fileUpdateAction in fileUpdateActions.Where(file => file.Type == FileUpdateActionType.Remove))
            {
                var filePath = Path.Combine(_directory, fileUpdateAction.FileName);

                File.Delete(filePath);
            }

            foreach (var fileUpdateAction in fileUpdateActions.Where(file => file.Type == FileUpdateActionType.Save))
            {
                var filePath = Path.Combine(_directory, fileUpdateAction.FileName);

                using (var stream = new StreamWriter(filePath))
                {
                    var json = JsonConvert.SerializeObject(fileUpdateAction.SaveInformation);
                    stream.Write(json);
                }
            }
        }

        public Dictionary<string, T> Load()
        {
            if (!Directory.Exists(_directory))
            {
                return new Dictionary<string, T>();
            }

            var files = GetAllRelevantFiles();

            var result = new Dictionary<string, T>();

            foreach (var fileInfo in files)
            {
                using (var stream = new StreamReader(fileInfo.FullName))
                {
                    var json = stream.ReadToEnd();
                    var t = string.IsNullOrWhiteSpace(json) ? default(T) : JsonConvert.DeserializeObject<T>(json);

                    result.Add(fileInfo.Name, t);
                }
            }

            return result;
        }

        public Dictionary<string, T> Load(string fileName)
        {
            if (!Directory.Exists(_directory) || !File.Exists(Path.Combine(_directory, fileName)))
            {
                return new Dictionary<string, T>();
            }

            var filePath = Path.Combine(_directory, fileName);

            using (var stream = new StreamReader(filePath))
            {
                var json = stream.ReadToEnd();
                return new Dictionary<string, T>
                {
                    {fileName, JsonConvert.DeserializeObject<T>(json)}
                };
            }
        }

        private IEnumerable<FileInfo> GetAllRelevantFiles()
        {
            var directoryInfo = new DirectoryInfo(_directory);

            if (!directoryInfo.Exists)
            {
                return new List<FileInfo>();
            }

            return directoryInfo.EnumerateFiles().Where(file => _fileExtensions.Contains(file.Extension));
        }

        public List<InformationObject> GetInformationObjects()
        {
            return GetAllRelevantFiles().Select(file => new InformationObject
            {
                FileName = file.Name,
                LastUpdateTime = file.LastWriteTime,
                Type = _objectType
            }).ToList();
        }
    }

    public class FileUpdateAction<T>
    {
        public string FileName { get; set; }
        public FileUpdateActionType Type { get; set; }
        public T SaveInformation { get; set; }
    }

    public enum FileUpdateActionType
    {
        Remove,
        Save
    }
}