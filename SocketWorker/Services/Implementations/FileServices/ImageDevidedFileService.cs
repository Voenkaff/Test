using System.Collections.Generic;
using System.Drawing;
using Models;

namespace Services.Services.Implementations.FileServices
{
    public class ImageDevidedFileService : DevidedFileService<byte[]>
    {
        public ImageDevidedFileService(string savePath) : base(savePath, "images", new List<string> {".btmp"},
            ObjectType.Image)
        {
        }
    }
}