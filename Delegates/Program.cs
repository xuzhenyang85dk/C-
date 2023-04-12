namespace Delegates
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Maskine m = new Maskine();
            m.start();
            m.stop();
        }

    }

    // Action
    public delegate void LogDelegate(string txt);

    // Func
    public delegate int LogDelegate1(int a);

    // Predicate
    public delegate bool LogDelegate3(int a);

    class Maskine{

        public Action<string> logDelegate;
        //public LogDelegate logDelegate;

        public void start()
        {
            Log("Jeg starter");
        }   
        public void stop() {
            Log("Jeg stopper");
        }

        private void Log (string msg) { 
            string d = DateTime.Now.ToLongDateString();

            // hard coupling
            //Console.WriteLine(d + msg);

            if(logDelegate != null)
            {
                logDelegate(d + msg);
            }
        }

        public static void Test(string a) {
            Console.WriteLine(a);
        }

        public static void Test2(string a)
        {
            System.IO.File.AppendAllText(@"C:\Kursus\OpgVariabler\Delegates\Log\log.txt", a);
        }

        public static void Test3(string a)
        {
            Console.WriteLine(" **** DB **** " + a);
        }
    }
}