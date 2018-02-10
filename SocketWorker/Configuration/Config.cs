using System.IO;

namespace Services.Configuration
{
    public class Config
    {
        public string SaveFolder { get; set; } = Path.Combine(Directory.GetCurrentDirectory(), "save");
    }
}