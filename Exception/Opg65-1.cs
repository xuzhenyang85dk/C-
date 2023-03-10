using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    internal class Opg65_1
    {
        static void Main(string[] args)
        {
            Run();
        }
        private static void Run()
        {
            int amount = 3;

            for (int i = 0; i < amount; i++)
            {
                try
                {
                    PrintText("Indtast 1. tal");
                    int tal1 = GetNumber();
                    PrintText("Indtast 2. tal");
                    int tal2 = GetNumber();
                    int res = tal1 + tal2;
                    PrintText("resultatet er " + res);
                    break;
                }
                catch (System.Exception ex)
                {
                    PrintText("Der er sket en fejl " + ex.Message);
                    PrintText("Prøv igen - du har i alt :" + (3-i) + " forsøg");

                }
            }
        }

        private static int GetNumber()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        private static void PrintText(string str)
        {
            Console.WriteLine(str);
        }
    }
}
