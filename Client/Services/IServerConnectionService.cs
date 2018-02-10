using System.Collections.Generic;
using Models;
using Models.TransferObjects;

namespace Client.Services
{
    public interface IServerConnectionService
    {
        bool IsConnected();
        List<InformationObject> GetTestInformationObjects();
        List<TestTransferObject> GetTests(List<InformationObject> testInformationObjects);
        List<InformationObject> GetImageInfromationObjects();
        List<ImageTransferObject> GetImages(List<InformationObject> informationObjects);
        List<Platoon> GetPlatoons();
        List<Subject> GetSubjects();
    }
}