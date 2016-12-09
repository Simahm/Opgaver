using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20PropertyChanged
{
    class Person
    {
        public event EventHandler PropertyChanged;
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                onPropertyChangedEventHandler();
                id = value;
            }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                onPropertyChangedEventHandler();
                name = value;
            }
        }
        
        private void onPropertyChangedEventHandler()
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new EventArgs());
        }
    }
}
