using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Animals
{
    public class Bug  :  Animal , Ianimal
    {
        public Bug(string Name)
        {
           this.name = Name;
        }


        public Bug(Bug t)   //  copy constructor
        {
            name = t.name;
            age = t.age;
            weight = t.weight;
        }

        public void PrintDetails(Animal a)
        {
            MessageBox.Show("I am a Bug and my name is " + this.Name);
        }

    }
}
