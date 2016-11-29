using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Polymorfi
{
    class Instruktør : Person
    {
        public int NøgleId { get; set; }

        public override string Skriv()
        {
            return $"{base.Fornavn} {base.Efternavn} {NøgleId}";
        }
    }
}
