using System;
using System.Collections.Generic;
using System.IO;
using System.ServiceProcess;
using System.Text;
using Windows_CoreApp_2._2.Interface;

namespace Windows_CoreApp_2._2.Service
{
    class USPSService : ServiceBase, IUSPSService
    {
        public USPSService()
        {
        }

        

        protected override void OnStart(string[] args)
        {
            USPSService s = new USPSService();
            int i = 0;
            int val = s.DoProcess(i);
            s.DoSomeRealProcess(val);
            StreamWriter wr = new StreamWriter(@"D:\reecordDone.txt", true);
            wr.WriteLine("Done");
            wr.Close();
            // wr.WriteLine("Service stoping now.");
        }

        protected override void OnStop()
        {
            StreamWriter wr = new StreamWriter(@"D:\recordsStopped.txt", true);
            wr.WriteLine("Service stoping now.");
            wr.Close();
        }
        public int DoProcess(int i)
        {
            i+=5;
            return i;
        }

        public void DoSomeRealProcess(int i)
        {
            StreamWriter wr = new StreamWriter(@"D:\recordsavedd.txt",true);
            wr.WriteLine(i);
            wr.Close();

        }
    }
}
