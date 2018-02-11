using System.Collections.Generic;

namespace Models.Test
{
    public class Test
    {
        public string Name { get; set; }
        public Subject Subject { get; set; }
        public Marks Marks { get; set; }
        public ICollection<Task> Tasks { get; set; } = new List<Task>();
    }
}