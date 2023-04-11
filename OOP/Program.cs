namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        class Hund
        {
            //Propfull ++tab
            private int antalBen;

            public int AntalBen
            {
                get { 
                    return antalBen; 
                }
                set { antalBen = value; }
            }

        }

    }
}