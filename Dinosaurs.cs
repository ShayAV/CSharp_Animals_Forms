using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Animals
{
    class Dinosaur  :  Animal, Ianimal 
    {
        public Dinosaur(string Name)
        {
            this.name = Name;
        }

        //new public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //}

        public void PrintDetails(Animal a)
        {
            MessageBox.Show("I am a Dinosaur and my name is " + this.Name);
        }

    }
}
