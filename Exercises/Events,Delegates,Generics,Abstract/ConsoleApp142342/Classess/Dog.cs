using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Classess
{
    public class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog() { }

        public override void Print()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Breed: {Breed}");
        }

        public void Bark()
        {
            Console.WriteLine("BARK! BARK!");
        }
    }
}
