using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Polymorfi
{
    public class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public virtual string Skriv()
        {
            return $"{this.Fornavn} {this.Efternavn}";
        }
    }
}
