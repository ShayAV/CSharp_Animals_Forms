using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Animals
{  
    public class Fish : Animal , Ianimal
    {

        public Fish(string Name)
        {
            this.name = Name;
        }

        /// <summary>
        /// prints the animal details
        /// </summary>
        public void PrintDetails(Animal a)  
        {          
            MessageBox.Show("I am a fish and my name is " + this.Name);
        }
    }
}
