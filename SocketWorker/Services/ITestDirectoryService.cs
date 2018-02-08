using System.Collections.Generic;
using Models;

namespace Services.Services
{
    public interface ITestDirectoryService
    {
        List<TestContainer> GetTests();
        List<InformationObject> GetTestInformationObjects();
        byte[] GetImage(string name);
    }
}