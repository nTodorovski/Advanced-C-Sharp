using Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Services
{
    public class GameService
    {
        private List<Event> _events;
        public List<Event> GetEvents()
        {
            string path = @"C:\Users\nikola.ztodorovski\Desktop\sedc7-06-csharpadvanced\g4\Class 15\AdventureGame\Services\Events\events.json";

            string result = String.Empty;
            using (StreamReader sr = new StreamReader(path))
            {
                result = sr.ReadToEnd();
            }

            _events = JsonConvert.DeserializeObject<List<Event>>(result);
            return _events;
        }

        public void ShowHeroStats(Hero hero,Event eventce)
        {
            Console.WriteLine($"Event Title: {eventce.Title}");
            Console.WriteLine($"Event Type: {eventce.Type.ToString()}");
            Console.WriteLine($"Event Description: {eventce.Description}");
            hero.Health += eventce.HealthModifier;
            hero.Armor += eventce.ArmorModifier;
            hero.Food += eventce.FoodModifier;
            Console.WriteLine($"Hero Health = {hero.Health}");
            Console.WriteLine($"Hero Armor = {hero.Armor}");
            Console.WriteLine($"Hero Food = {hero.Food}");
        }

        public void Game()
        {
            int point = 0;
            Hero hero = new Hero();
            List<Event> events = GetEvents();
            while (true)
            {
                Console.WriteLine("Press any key to Roll the Dice!");
                Console.WriteLine("---------------------------------");
                string input = Console.ReadLine();
                if(input == "aspirine")
                {
                    hero.Health = 999;
                }
                int rollDice = hero.RollDice();
                Console.WriteLine($"You rolled {rollDice}!");
                Console.WriteLine();
                point += rollDice;
                if(point >= 30)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("YOU WON THE GAME!");
                    break;
                }
                Console.WriteLine($"You are on point {point}!");
                Console.WriteLine();
                Event currentEvent = events[point+1];
                ShowHeroStats(hero, currentEvent);
                if (!hero.IsAlive())
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("YOU ARE DEAD!");
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You are still good!");
                    Console.ResetColor();
                }
                Console.WriteLine("---------------------------------");
            }
        }
    }
}
