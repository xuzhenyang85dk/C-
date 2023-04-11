namespace Class
{
    class Terning
    {
        // field
        public int værdi;

        // root constructor
        public Terning()
        {
            this.værdi = 1;
        }
        public Terning(int n) { 
            if (værdi < 1 || værdi > 6)
                    throw new ApplicationException("Forkert værdi");
            this.værdi = n;
        }
        /// <summary>
        ///    Ryst method 
        /// </summary>
        public void Ryst()
        {
            System.Random rnd = new System.Random();
            this.værdi = rnd.Next(1, 7);
        }
    }
}
