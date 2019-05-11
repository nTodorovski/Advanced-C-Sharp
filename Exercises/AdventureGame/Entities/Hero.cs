using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Hero
    {
        public int Health { get; set; }
        public int Armor { get; set; }
        public int Food { get; set; }

        public Hero()
        {
            Health = 60;
            Armor = 40;
            Food = 60;
        }

        public int RollDice()
        {
            return new Random().Next(1, 7);
        }

        public bool IsAlive()
        {
            if (Health <= 0) return false;
            return true;
        }
    }
}
