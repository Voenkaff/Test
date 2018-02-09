using System.Collections.Generic;
using Models;

namespace Services.Services
{
    public interface ISubjectFileService
    {
        void Update(List<Subject> subjects);
        List<Subject> Load();
    }
}