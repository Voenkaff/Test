using System;
using System.Net.NetworkInformation;

namespace Tests
{
    class Program
    {
        public static void Main(string[] args)
        {
            foreach (var ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                foreach (var ip in ni.GetIPProperties().UnicastAddresses)
                {
                    if (ip.IsDnsEligible) continue;

                    if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        Console.WriteLine(ip.Address);
                    }
                }
            }

            Console.Read();
        }
    }
}
