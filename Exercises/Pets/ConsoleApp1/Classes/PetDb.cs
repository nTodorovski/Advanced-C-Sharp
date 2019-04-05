using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public static class PetDb
    {
        public static List<Dog> dogs = new List<Dog>()
        {
            new Dog("Sharko",15,"Milenko",true,"Dog Food"),
            new Dog("Petko",3,"Telma",true,"Dog Food")
        };
        public static List<Cat> cats = new List<Cat>()
        {
            new Cat("Fibi",4,"Marija",7,true),
            new Cat("Cat",4,"Jill",4,false)
        };
    }
}
