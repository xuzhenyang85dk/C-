using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Delegates120_3
    {
        static void Main1(string[] args)
        {
            Maskine m = new Maskine();
            m.Log = Console.WriteLine;
            m.Log += AppendLog;
            m.Start();
            m.Stop();
        }
        static void AppendLog(string txt)
        {
            // the folder needs be exists
            System.IO.File.AppendAllText(@"C:\Kursus\OpgVariabler\Delegates\Log\log.txt", txt + "\r\n");
        }

        public delegate void LogDelegate(string txt);
        public class Maskine
        {
            public LogDelegate Log;

            public void Start()
            {
                Log?.Invoke(DateTime.Now.ToLongTimeString() + " Starter");
            }
            public void Stop()
            {
                Log?.Invoke(DateTime.Now.ToLongTimeString() + " Stopper");
            }

        }
    }
}
