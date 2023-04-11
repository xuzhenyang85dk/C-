using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDice
{
    internal class Person
    {
        // From fields to properties
        /*
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;
        */
        public string Fornavn { get; set; }
        public string Efternavn;
        public int Fødselsår;

        public string FuldtNavn()
        {
            return $"{Fornavn} {Efternavn}";
        }

        public int EstimeretAlder()
        {
            int år = DateTime.Now.Year;
            return år - this.Fødselsår;
        }

        // default constructor
        public Person()
        {
            this.Fornavn = "";
            this.Efternavn = "";
        }

        // Custom constructor
        public Person(string fornavn, string efternavn, int fødselsår)
        {
            this.Fødselsår = fødselsår;
            this.Fornavn = fornavn;
            this.Efternavn = efternavn;
        }
    }

}
