namespace Array
{
    internal class Test
    {
        static void Main1(string[] args)
        {
            try
            {
                int[] a = new int[8];
                string[] b = new string[100_000];

                a[0] = 200;
                a[8] = 100;
                // For loop
                for (int i = 0; i < a.Length; i++)
                {
                    Console.WriteLine(a[i]);
                }
                // Foreach
                foreach (int i in a)
                {
                    Console.WriteLine(i);
                }
                
                // Lambda
                System.Array.ForEach(a,x => Console.WriteLine(x));

                System.Array.Sort(a);



            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            
        }
    }
}