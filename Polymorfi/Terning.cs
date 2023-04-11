namespace Polymorfi
{
    internal partial class OpgPolymorfi
    {
        class Terning
        {
            private static System.Random rnd;
            private int værdi;

            public int Værdi
            {
                get { return this.værdi; }
                set {
                    if (value < 0 || value > 6)
                        this.værdi = 1;                    
                    this.værdi = value; }
            }
            
            

            public virtual void Ryst()
            {
                this.Værdi = rnd.Next(1,7);
            }

            public virtual void Skriv()
            {
                Console.WriteLine("Værdi: " + this.Værdi);
            }

            public Terning()
            {
                this.Ryst();
            }
            public Terning(int værdi)
            {
                this.Værdi= værdi;
            }

            static Terning()
            {
                rnd = new Random();
            }
        }
    }
}