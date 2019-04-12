using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Classess
{
    public class Cat : Animal
    {
        public bool IsLazy { get; set; }

        public Cat() { }

        public override void Print()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Is the cat lazy? - {IsLazy}");
        }

        public void Meow()
        {
            Console.WriteLine("MEOW");
        }
    }
}
