using System.Collections.Generic;

namespace Models
{
    public class Platoon
    {
        public string Name { get; set; }
        public List<string> Students { get; set; } = new List<string>();
    }
}