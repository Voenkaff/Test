using System.Collections.Generic;
using Models;

namespace Services.Services.Implementations.FileServices
{
    public class TestDevidedFileService : DevidedFileService<Test>
    {
        public TestDevidedFileService(string savePath) : base(savePath, "tests", new List<string> {".test"},
            ObjectType.Test)
        {
        }
    }
}