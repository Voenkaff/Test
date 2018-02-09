using System.Collections.Generic;
using Models;
using Models.TransferObjects;

namespace Services.Services
{
    public interface ITestDirectoryService
    {
        List<TestContainer> GetTests();
        List<InformationObject> GetTestInformationObjects();
        ImageTransferObject GetImage(string name);
    }
}