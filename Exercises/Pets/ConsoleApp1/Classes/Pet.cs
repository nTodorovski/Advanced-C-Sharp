using ConsoleApp1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string OwnerName { get; set; }
        public Tip Type { get; set; }
        public abstract void PrintPet();
        public Pet(string name,int age,string ownerName)
        {
            Name = name;
            Age = age;
            OwnerName = ownerName;
        }
    }
}
