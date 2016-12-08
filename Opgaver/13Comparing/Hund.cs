using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Comparing
{
    class Hund : IComparable
    {
        public string Navn { get; set; }
        public int Alder { get; set; }

        public int CompareTo(object obj)
        {
            Hund h = obj as Hund;
            if (this.Alder > h.Alder)
                return 1;
            if (this.Alder < h.Alder)
                return -1;          
            return 0;
        }
    }
}
