using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Terning
    {

        static void Main2(string[] args)
        {
            TerningT t = new TerningT();
            t.Ryst();
            t.Skriv();
        }
        class TerningT 
        {
            private int værdi;

            public int Værdi
            {
                get { return værdi; }
                set {
                    if (value < 1 || value > 6)
                        this.værdi = 1;
                     this.værdi = value; 
                }
            }

            private static System.Random rnd = new System.Random();

            public void Ryst()
            {
                this.værdi = rnd.Next(1,7);
            }

            public void Skriv()
            {
                Console.WriteLine("Værdi: " + this.værdi);
            }

            public TerningT()
            {
                Ryst();
            }
            public TerningT(int tal)
            {
                
            }

        }
    }
}
