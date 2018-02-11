using System.Collections.Generic;
using Models;
using Models.Test;
using Models.TransferObjects;

namespace Client.Services
{
    public interface IServerConnectionService
    {
        bool IsConnected();
        List<InformationObject> GetTestInformationObjects();
        Dictionary<string, Test> GetTests(List<InformationObject> testInformationObjects);
        List<InformationObject> GetImageInfromationObjects();
        Dictionary<string, byte[]> GetImages(List<InformationObject> informationObjects);
        List<Platoon> GetPlatoons();
        List<Subject> GetSubjects();
    }
}