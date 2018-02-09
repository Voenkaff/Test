using System.IO;
using Newtonsoft.Json;

namespace Client
{
    public class ClientConfiguration
    {
        private const string ConfigurationFileName = "Configuration.json";

        private static readonly string ConfigurationFilePath =
            $"{Directory.GetCurrentDirectory()}//{ConfigurationFileName}";

        private static readonly ClientConfiguration Configuration = Initialize();

        private ClientConfiguration()
        {
        }

        public string ServerIp { get; set; }
        public int ServerPort { get; set; }
        public string TestFolder { get; set; }
        public string ImageFolder { get; set; }

        public void SaveConfiguration()
        {
            using (var stream = new StreamWriter(ConfigurationFilePath))
            {
                var json = JsonConvert.SerializeObject(this);
                stream.Write(json);
            }
        }

        public static ClientConfiguration GetInstance()
        {
            return Configuration;
        }

        private static ClientConfiguration Initialize()
        {
            var configuration = LoadConfiguration(ConfigurationFilePath);

            if (configuration != null) return configuration;

            configuration = new ClientConfiguration
            {
                ServerIp = "127.0.0.1",
                ServerPort = 8080,
                TestFolder = "tests",
                ImageFolder = "imsages"
            };

            configuration.SaveConfiguration();

            return configuration;
        }

        private static ClientConfiguration LoadConfiguration(string configurationFilePath)
        {
            if (!File.Exists(configurationFilePath))
            {
                return null;
            }

            using (var stream = new StreamReader(configurationFilePath))
            {
                var json = stream.ReadToEnd();
                return JsonConvert.DeserializeObject<ClientConfiguration>(json);
            }
        }
    }
}