using System.IO;
using Newtonsoft.Json;

namespace Editor
{
    public class EditorConfiguration
    {
        private const string ConfigurationFileName = "Configuration.json";

        private static readonly string ConfigurationFilePath =
            $"{Directory.GetCurrentDirectory()}//{ConfigurationFileName}";

        private static readonly EditorConfiguration Configuration = Initialize();

        private EditorConfiguration()
        {
        }

        public string SaveFolder { get; set; }

        public void SaveConfiguration()
        {
            using (var stream = new StreamWriter(ConfigurationFilePath))
            {
                var json = JsonConvert.SerializeObject(this);
                stream.Write(json);
            }
        }

        public static EditorConfiguration GetInstance()
        {
            return Configuration;
        }

        private static EditorConfiguration Initialize()
        {
            var configuration = LoadConfiguration(ConfigurationFilePath);

            if (configuration != null) return configuration;

            configuration = new EditorConfiguration
            {
                SaveFolder = $"{Directory.GetCurrentDirectory()}//result"
            };

            configuration.SaveConfiguration();

            return configuration;
        }

        private static EditorConfiguration LoadConfiguration(string configurationFilePath)
        {
            if (!File.Exists(configurationFilePath))
            {
                return null;
            }

            using (var stream = new StreamReader(configurationFilePath))
            {
                var json = stream.ReadToEnd();
                return JsonConvert.DeserializeObject<EditorConfiguration>(json);
            }
        }
    }
}
