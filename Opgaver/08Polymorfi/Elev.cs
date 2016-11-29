using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Polymorfi
{
    class Elev : Person
    {
        public string Klasselokale { get; set; }

        public override string Skriv()
        {
            return $"{base.Skriv()} {Klasselokale}";
        }
    }
}
