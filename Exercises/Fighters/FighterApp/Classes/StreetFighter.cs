﻿using FighterApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FighterApp.Classes
{
    public class StreetFighter : Fighter, IStreet
    {
        public double StreetCredit { get; set; }

        public StreetFighter(string name, double health, double powerPunch, double speed, double streetCredit) : base(name,health, powerPunch, speed)
        {
            StreetCredit = streetCredit;
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

        protected override void Finisher(Fighter opponent)
        {
            Console.WriteLine($"I AM {Name.ToUpper()}");
        }
    }
}
