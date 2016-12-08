using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15CollectionsDemo
{
    class Bunke
    {
        private Stack<Kort> stak = new Stack<Kort>();

        public void TilføjKort(Kort k)
        {
            stak.Push(k);
        }

        public Kort FjernKort()
        {
            if (stak.Count > 0)
                return stak.Pop();
            return null;
        }

        public void VisKort()
        {
            foreach (var item in stak)
            {
                Console.WriteLine(item);
            }
        }
    }

}
