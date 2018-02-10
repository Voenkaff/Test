using System.Collections.Generic;
using System.Linq;
using Models;
using Services.Services.Implementations;
using Services.Services.Implementations.FileServices;

namespace Editor.Forms.Workers
{
    public class PlatoonWorker
    {
        private readonly PlatoonFileService _platoonFileService;
        private readonly List<Platoon> _platoons;

        public PlatoonWorker(string savePath)
        {
            _platoonFileService = new PlatoonFileService(savePath);
            _platoons = _platoonFileService.Load();
        }

        public object[] GetPlatoonStudentNamesAsObjects(string platoonName)
        {
            var platoon = GetPlatoon(platoonName);

            return platoon?.Students.Select(s => (object) s).ToArray() ?? new object[0];
        }

        public void AddStudentInPlatoon(string platoonName, string studentName)
        {
            var platoon = GetPlatoon(platoonName);
            platoon.Students.Add(studentName);
        }

        public void AddPlatoon(string platoonsName)
        {
            _platoons.Add(new Platoon
            {
                Name = platoonsName
            });
        }

        public void RemovePlaton(string platoonName)
        {
            _platoons.Remove(GetPlatoon(platoonName));
        }

        public Platoon GetPlatoon(string platoonName)
        {
            return _platoons.FirstOrDefault(p => p.Name == platoonName);
        }

        public void ClearPlatoon()
        {
            _platoons.Clear();
        }

        public void ClearStudents(string platoonName)
        {
            var platoon = GetPlatoon(platoonName);
            platoon.Students.Clear();
        }

        public void RemoveStudent(string platoonName, string studentName)
        {
            var platoon = GetPlatoon(platoonName);
            platoon.Students.Remove(studentName);
        }

        public object[] GetPlatoonNamesAsObjects()
        {
            return _platoons.Select(p => (object) p.Name).ToArray();
        }

        public void Save()
        {
            _platoonFileService.Update(_platoons);
        }
    }
}