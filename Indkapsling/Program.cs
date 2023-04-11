namespace Indkapsling
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Vare vare = new Vare();
            vare.Navn = "vare 1";
            vare.Pris = 100;
            double res = vare.PrisMedMoms();
            Console.WriteLine(res);
        }

        class Vare
        {
            public Vare() { }
            public Vare (string navn, double pris) {
                this.Navn = navn;
                this.Pris= pris;
            }
            private string navn;

            public string Navn
            {
                get 
                {
                    Console.WriteLine("Nu aflæses navn");
                    return navn; 
                }
                set 
                {
                    Console.WriteLine("Nu tildeles navn");
                    navn = value; 
                }
            }

            private double pris;
            public double Pris
            {
                get 
                { 
                 
                    Console.WriteLine("Nu aflæses pris");
                    return pris; 
                }
                set 
                {
                    Console.WriteLine("Nu tildeles pris");
                    pris = value; 
                }
            }

            public double PrisMedMoms()
            {
                return this.pris * 0.75;
            }

        }

        
    }
}