using System;

namespace Indkapsling
{
    internal class _90_1
    {
        static void Main2(string[] args)
        {
            Terning t1 = new Terning();
            t1.Skriv();

            // eller
            Console.WriteLine(t1.Værdi);

            t1.Ryst();
            t1.Skriv();
            t1.Værdi = 7;
            t1.Skriv() ;
            t1 = new Terning(6);
            t1.Skriv();
        }

        class Terning{
            
            // properties
            private int værdi;
            public int Værdi{
                get {
                    Console.WriteLine("Nu aflæses værdi " + this.værdi);
                    return this.værdi; 
                }
                set{
                    
                    if(value < 1 || value > 6)
                        value = 1;
                    Console.WriteLine("Nu tildeles værdi");
                    this.værdi = value; 
                }
            }
            
            // Ryst method
            public void Ryst(){
                System.Random rnd = new System.Random();
                this.Værdi = rnd.Next(1,7);
            }

            // Skriv method
            public void Skriv(){
                System.Console.WriteLine(" " + this.Værdi + " ");
            }

            // constructors
            public Terning()
            {
                this.Ryst();
            }

            public Terning(int værdi)
            {
                this.Værdi = værdi;
            }

        }

        
    }
}
