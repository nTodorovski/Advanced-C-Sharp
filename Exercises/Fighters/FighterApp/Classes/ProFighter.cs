using FighterApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FighterApp.Classes
{
    public class ProFighter : Fighter, IBox, IStreet
    {
        public double Experience { get; set; }

        public ProFighter(string name, double health, double powerPunch, double speed, double experience) : base(name, health, powerPunch, speed)
        {
            Experience = experience;
        }

        public void DoStreet(Fighter opponent)
        {
            double punch = PowerPunch;
            if (opponent.IsDizzy() || opponent.GetHealth() <= punch)
            {
                Console.WriteLine($"{opponent.Name} is Dizzy!");
                Finisher(opponent);
                opponent.TakeDamage(punch);
                if (opponent.GetHealth() <= 0)
                {
                    opponent.TakeDamage();
                    Console.WriteLine($"{Name} won.");
                    return;
                }
            }
            else
            {
                opponent.TakeDamage(punch);
                Console.WriteLine($"{opponent.Name} took {punch} damage!");
                Console.WriteLine($"{opponent.Name} has {opponent.GetHealth()} health!");
            }
        }

        public void DoBoxing(Fighter opponent)
        {
            double punch = PowerPunch + Experience;
            if (opponent.IsDizzy() || opponent.GetHealth() <= punch)
            {
                Console.WriteLine($"{opponent.Name} is Dizzy!");
                Finisher(opponent);
                opponent.TakeDamage(punch);
                if(opponent.GetHealth() <= 0)
                {
                    opponent.TakeDamage();
                    Console.WriteLine($"{Name} won.");
                    return;
                }
            }
            else
            {
                opponent.TakeDamage(punch);
                Console.WriteLine($"{opponent.Name} took {punch} damage!");
                Console.WriteLine($"{opponent.Name} has {opponent.GetHealth()} health!");
            }
        }

        protected override void Finisher(Fighter opponent)
        {
            Console.WriteLine($"I AM {Name.ToUpper()} !!!");
        }
    }
}
