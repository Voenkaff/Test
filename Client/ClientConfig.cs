using Services.Configuration;

namespace Client
{
    public class ClientConfig : Config
    {
        public string ServerIp { get; set; } = "127.0.0.1";
        public int ServerPort { get; set; } = 8080;
        public string TestFolder { get; set; } = "tests";
        public string ImageFolder { get; set; } = "imsages";
    }
}