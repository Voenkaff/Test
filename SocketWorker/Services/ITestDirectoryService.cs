using System.Collections.Generic;
using Models;
using Models.Test;
using Models.TransferObjects;

namespace Services.Services
{
    public interface ITestDirectoryService
    {
        List<Test> GetTests();
        List<InformationObject> GetTestInformationObjects();
        ImageTransferObject GetImage(string name);
    }
}