using ConsoleApp1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class Cat : Pet
    {
        public bool IsLazy { get; set; }
        private int _livesLeft;
        public int LivesLeft
        {
            get
            {
                return _livesLeft;
            }
            set
            {
                if (value < 1 || value > 9)
                {
                    Console.WriteLine("Lives Left cannot be set below 1 or above 9");
                    _livesLeft = 1;
                }
                else
                {
                    _livesLeft = value;
                }
            }
        }

        public Cat(string name, int age, string ownerName,int livesLeft,bool isLazy):base(name, age, ownerName)
        {
            LivesLeft = livesLeft;
            IsLazy = IsLazy;
            Type = Tip.Cat;
        }
        public override void PrintPet()
        {
            Console.WriteLine($"Name: {Name} \nAge: {Age} \nOwnerName: {OwnerName} \nType: {Type} \nLives Left: {LivesLeft} \nIs Lazy: {IsLazy}");
        }
    }
}