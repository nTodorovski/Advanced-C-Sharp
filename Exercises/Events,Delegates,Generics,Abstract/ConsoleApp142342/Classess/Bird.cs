using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Classess
{
    public class Bird : Animal
    {
        public bool IsWild { get; set; }

        public Bird() { }

        public override void Print()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Is the bird wild? - {IsWild}");
        }

        public void FlySouth()
        {
            if (IsWild)
            {
                Console.WriteLine("Flying South");
            }
            else
            {
                Console.WriteLine("Domesticated Bird");
            }  
        }
    }
}
