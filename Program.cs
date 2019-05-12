using System;
using System.IO;
using System.ServiceProcess;
using Windows_CoreApp_2._2.Service;

namespace Windows_CoreApp_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var service = new USPSService())
            {
                StreamWriter wr = new StreamWriter(@"D:\Inprogram.txt", true);
                wr.WriteLine("I am working fine in program.cs!!");
                wr.Close();
                ServiceBase.Run(service);
            }
        }
    }
}
