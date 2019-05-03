using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int igridients = 0;
            string folderPath = @"C:\Users\nikola.ztodorovski\source\repos\ConsoleApp2\ConsoleApp2\recepti";
            Console.WriteLine("Enter the name of the recipe:");
            string recipeName = Console.ReadLine();
            if (!File.Exists(folderPath + $@"\{recipeName}.txt"))
            {
                File.Create(folderPath + $@"\{recipeName}.txt").Close();
                Console.WriteLine("File was created!");
            }

            string filePath = folderPath + $@"\{recipeName}.txt";


            Console.WriteLine("How many ingridients the recipe has?");
            bool input = int.TryParse(Console.ReadLine(), out igridients);
            
            if(input && igridients > 0)
            {
                int count = 1;
                List<string> ingridientsList = new List<string>();
                for (int i = 0; i < igridients; i++)
                {
                    Console.WriteLine($"Enter the {count} ingridient:");
                    string name = Console.ReadLine();
                    if (String.IsNullOrEmpty(name))
                    {
                        Console.WriteLine("Ingridient Name is Empty");
                    }
                    else
                    {
                        ingridientsList.Add(name);
                        count++;
                    }
                }

                int countIngridient = 1;

                using(StreamWriter sw = new StreamWriter(filePath, true))
                {
                    foreach (var ingridient in ingridientsList)
                    {
                        sw.WriteLine($"{countIngridient}. {ingridient}");
                        countIngridient++;
                    }
                };
            }
            else
            {
                Console.WriteLine("A recipe cannot has 0 or less ingridients");
            }
            Console.WriteLine("Thank You and Goodbye!");
            Console.ReadLine();
        }
    }
}
