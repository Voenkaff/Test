using System.IO;
using Newtonsoft.Json;

namespace Services.Configuration
{
    public class ConfigContainer
    {
        private static Config _config;

        public static T GetConfig<T>() where T : Config, new()
        {
            if (_config != null) return (T) _config;

            _config = LoadConfiguration(new T());
            SaveConfiguration();
            return (T) _config;
        }

        private static T LoadConfiguration<T>(T t)
        {
            var configurationFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Configuration.json");

            if (!File.Exists(configurationFilePath))
            {
                return t;
            }

            using (var stream = new StreamReader(configurationFilePath))
            {
                var json = stream.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(json);
            }
        }

        public static void SaveConfiguration()
        {
            var configurationFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Configuration.json");

            using (var stream = new StreamWriter(configurationFilePath))
            {
                var json = JsonConvert.SerializeObject(_config);
                stream.Write(json);
            }
        }
    }
}