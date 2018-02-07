using System;

namespace Models
{
    public class InformationObject
    {
        public string FileName { get; set; }
        public ObjectType Type { get; set; }
        public DateTime LastUpdateTime { get; set; }
    }

    public enum ObjectType
    {
        Test,
        Picture
    }
}