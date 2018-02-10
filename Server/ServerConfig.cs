using Services.Configuration;

namespace Server
{
    public class ServerConfig : Config
    {
        public string ServerIp { get; set; } = "127.0.0.1";
        public int ServerPort { get; set; } = 8080;
        public string TestFolder { get; set; } = "tests";
        public string ResultFolder { get; set; } = "results";
    }
}