using Models;

namespace Services.Services.Implementations.FileServices
{
    public class SubjectFileService : FileService<Subject>
    {
        public SubjectFileService(string savePath) : base(savePath, "subjects", "subjects.json")
        {
        }
    }
}