using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FighterApp.Classes;

namespace FighterApp
{
    class Program
    {
        static void Main(string[] args)
        {

            StreetFighter mess = new StreetFighter("Mumin",120, 2, 1, 7);
            ProFighter ryu = new ProFighter("Bojka",150, 4, 2, 13);
            RockstarFighter blanka = new RockstarFighter("Blanka",170, 5, 4, 17);

            Console.WriteLine($"{ryu.Name} vs {blanka.Name}");
            while (true)
            {
                ryu.DoBoxing(blanka);
                if(blanka.GetHealth() == 0)
                {
                    break;
                }
                Thread.Sleep(300);
                blanka.DoBoxing(ryu);
                if(ryu.GetHealth() == 0)
                {
                    break;
                }
                Thread.Sleep(300);
            }
            Console.ReadLine();
        }
    }
}
