using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Services.Services.Implementations
{
    public class FileService<T>
    {
        private readonly string _filePath;
        private readonly string _directory;

        public FileService(string savePath, string directoryName, string fileName)
        {
            _directory = $"{savePath}//{directoryName}";
            _filePath = $"{_directory}//{fileName}";
        }

        public void Update(List<T> objects)
        {
            if (!File.Exists(_filePath))
            {
                if (!Directory.Exists(_directory))
                {
                    Directory.CreateDirectory(_directory);
                }
                File.Create(_filePath);
            }

            using (var stream = new StreamWriter(_filePath))
            {
                var json = JsonConvert.SerializeObject(objects);
                stream.Write(json);
            }
        }

        public List<T> Load()
        {
            if (!File.Exists(_filePath))
            {
                return new List<T>();
            }

            using (var strem = new StreamReader(_filePath))
            {
                var json = strem.ReadToEnd();

                return string.IsNullOrWhiteSpace(json) ? new List<T>() : JsonConvert.DeserializeObject<List<T>>(json);
            }
        }
    }
}
