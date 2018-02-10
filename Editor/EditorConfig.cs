using System.IO;
using Services.Configuration;

namespace Editor
{
    public class EditorConfig : Config
    {
        public string SaveFolder { get; set; } = Path.Combine(Directory.GetCurrentDirectory(), "save");
    }
}
