using Models;

namespace Services.Services.Implementations.FileServices
{
    public class PlatoonFileService : FileService<Platoon>
    {
        public PlatoonFileService(string savePath) : base(savePath, "platoons", "platoons.json")
        {
        }
    }
}