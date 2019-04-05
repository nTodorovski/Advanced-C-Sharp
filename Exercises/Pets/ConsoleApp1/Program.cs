using ConsoleApp1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            PetDb.cats[0].WhatPetIsThis();
            PetDb.cats[0].PrintPet();
            PetDb.cats.Add(new Cat("Trajanka", 5, "Trajanka Senior", 10, true));
            PetDb.cats[2].PrintPet();
            Console.WriteLine(PetDb.dogs[0].Age.ConvertDogYears());
            Console.ReadLine();
        }
    }
}