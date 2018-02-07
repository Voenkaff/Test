namespace VoenKaffServer
{
    public class Configuration
    {
        private static string _testFolder = "C:\\projects\\tests";

        public static string GetTestFolderPath()
        {
            lock (_testFolder)
            {
                return _testFolder;
            }
        }
    }
}