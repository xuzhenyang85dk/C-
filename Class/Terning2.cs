using System;

namespace ClassDice
{
    internal class Terning2
    {
        // fields
        public int værdi;
        private bool snyd;

        // root constructor
        public Terning2()
        {
            this.værdi = 1;
        }
        public Terning2(int værdi)
        {
            if (værdi < 1 || værdi > 6)
                throw new ApplicationException("Forkert værdi");
            this.værdi = værdi;
        }
        public void Ryst()
        {
            System.Random rnd = new System.Random();
            this.værdi = rnd.Next(1, 7);
        }

        public void Skiv()
        {
            Console.WriteLine(værdi);
        }
    }
}
