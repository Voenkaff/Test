namespace Client
{
    public class ClientConfiguration
    {
        public static string ServerIp { get; set; } = "127.0.0.1";
        public static int ServerPort { get; set; } = 8080;
        public static string TestFolder { get; set; } = "tests";
        public static string ImageFolder { get; set; } = "images";
    }
}