using System.Collections.Generic;

namespace Models.Socket
{
    public class Command
    {
        public CommandType CommandType { get; set; }

        public List<string> Args { get; set; }

        public static Command Update()
        {
            return new Command
            {
                CommandType = CommandType.Info
            };
        }

        public static Command Close()
        {
            return new Command
            {
                CommandType = CommandType.Close
            };
        }

        public static Command Tests(List<string> testNames)
        {
            return new Command
            {
                CommandType = CommandType.GetTests,
                Args = testNames
            };
        }

        public static Command GetImages(string imageName)
        {
            return new Command
            {
                CommandType = CommandType.GetImage,
                Args = new List<string> {imageName}
            };
        }

        public static Command GetImagesInfromation()
        {
            return new Command
            {
                CommandType = CommandType.GetImagesInformation
            };
        }
    }

    public enum CommandType
    {
        Info,
        Close,
        GetTests,
        GetImage,
        GetImagesInformation
    }
}