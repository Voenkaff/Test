using System;
using Services.Services.Implementations.FileServices;

namespace ForTests
{
    public class Program
    {
        public static void Main(string[] args)
        {


            var testDevidedFileService = new TestDevidedFileService("c://1234//1234");
            var informationObjects = testDevidedFileService.GetInformationObjects();
            var tests = testDevidedFileService.Load("test112.test");
            Console.ReadKey();
        }
    }
}