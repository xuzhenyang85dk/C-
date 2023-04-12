using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Delegate120_4
    {
        static void Main1(string[] args)
        {
            Maskine1 m = new Maskine1();
            Action<string> a1 = Console.WriteLine;
            m.Log = a1;

            m.Log += AppendLog;
            m.Start();
            m.Stop();
        }
        static void AppendLog(string txt)
        {
            // the folder needs be exists
            System.IO.File.AppendAllText(@"C:\Kursus\OpgVariabler\Delegates\Log\log.txt", txt + "\r\n");
        }

    }
    
    public class Maskine1
    {
        public Action<string> Log { get; set; }

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
