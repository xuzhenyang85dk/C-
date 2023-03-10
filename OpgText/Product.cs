using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgText
{
    internal class Product
    {
        public string Name { get; set; }    
        public DateTime Expiry { get; set; }
        public string[] Sizes { get; set; }
    }
}
