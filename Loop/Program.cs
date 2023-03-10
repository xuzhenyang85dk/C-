namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Tælle fra 0 - 9");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Tælle fra 1 til 20 men kun hver anden (1-3-5-7...");
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
                i += 1;
            }
            for (int i = 1; i <= 20; i++)
            {
                if (i / 2 != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(i);

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(i);
                    Console.ResetColor();
                }
            }

            for (int xx = 1; xx < 11; xx++)
            {
                for (int yy = 1; yy < 11; yy++)
                {
                    string tal = (xx * yy).ToString();
                    if ((xx * yy) > 50)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else
                        Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(tal.PadLeft(4));
                }
                Console.WriteLine();
            }

        }
    }
}