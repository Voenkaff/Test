using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using Models;

namespace Services.Services.Implementations.FileServices
{
    public class ImageDevidedFileService : DevidedFileService<byte[]>
    {
        public ImageDevidedFileService(string savePath) : base(savePath, "images", new List<string> {".bin"},
            ObjectType.Image)
        {
        }

        public void Update(List<FileUpdateAction<Bitmap>> fileUpdateActions)
        {
            var actions = fileUpdateActions.Where(action => action.Type == FileUpdateActionType.Save).Select(action =>
                new FileUpdateAction<byte[]>
                {
                    FileName = action.FileName,
                    SaveInformation = ConvertBitmapToByte(action.SaveInformation),
                    Type = FileUpdateActionType.Save
                }).ToList();

            Update(actions);
        }

        private static byte[] ConvertBitmapToByte(Image bitmap)
        {
            using (var stream = new MemoryStream())
            {
                bitmap.Save(stream, ImageFormat.Jpeg);
                return stream.ToArray();
            }
        }

        public Bitmap LoadAsBitmap(string fileName)
        {
            var bytes = Load(fileName)[fileName];

            using (var stream = new MemoryStream(bytes))
            {
                return new Bitmap(stream,false);
            }
        }
    }
}