using System.Collections.Generic;
using Models.TransferObjects;

namespace Client.Services
{
    public interface IClientTestFileService
    {
        void SaveTests(List<TestTransferObject> testTransferObjects);
        void SaveTest(TestTransferObject testTransferObject);
        void SaveImages(List<ImageTransferObject> imageTransferObjects);
        void SaveImage(ImageTransferObject imageTransferObject);
    }
}