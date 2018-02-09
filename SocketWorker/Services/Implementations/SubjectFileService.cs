using Models;

namespace Services.Services.Implementations
{
    public class SubjectFileService : FileService<Subject>
    {
        public SubjectFileService(string savePath) : base(savePath, "subjects", "subjects.json")
        {
        }
    }
}