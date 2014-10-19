using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Animals
{
    abstract public class Animal
    {
        public double age;
        public double weight;
        protected string name;

        //public Animal()     // default constructor
        //{
        //}

        //public Animal(string Name)
        //{
        //    MessageBox.Show("animal");
        //    this.name = Name;
        //}

        /// <summary>
        /// proprty age
        /// </summary>
        public double Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        
       
        


    }
}
