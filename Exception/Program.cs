namespace Exception
{
    internal class Program
    {
        static void Main2(string[] args)
        {
            try
            {
                int a = 0;
                int b = 100;
                int c = b/a;

            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Start");

        }

    }
}