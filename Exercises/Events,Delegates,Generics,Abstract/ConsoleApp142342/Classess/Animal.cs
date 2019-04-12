using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Classess
{
    public abstract class Animal
    {
        public string Name { get; set; }
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if(value < 0 || value > 175)
                {
                    Console.WriteLine("Age cannot be below 0 or more than 175.Please try again!");
                    return;
                }
                else
                {
                    _age = value;
                }
            }
        }
        public abstract void Print();
    }
}
