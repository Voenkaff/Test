using System.Collections.Generic;

namespace Models.Socket
{
    public class Command
    {
        public CommandType CommandType { get; set; }

        public List<string> Args { get; set; }

        public static Command GetTestInformation()
        {
            return new Command
            {
                CommandType = CommandType.GetTestInformation
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

        public static Command GetPlatoons()
        {
            return new Command
            {
                CommandType = CommandType.GetPlatoons
            };
        }

        public static Command GetSubjects()
        {
            return new Command
            {
                CommandType = CommandType.GetSubjects
            };
        }
    }

    public enum CommandType
    {
        GetTestInformation,
        GetTests,
        GetImage,
        GetImagesInformation,
        GetPlatoons,
        GetSubjects
    }
}