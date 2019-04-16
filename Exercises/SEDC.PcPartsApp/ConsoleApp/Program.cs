using Services;
using System;
using Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var parts = Db.Parts;
            var modules = Db.Modules;
            var configuration = Db.Configurations;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome!");
                Console.WriteLine("Choose Action:");
                Console.WriteLine("1. Part");
                Console.WriteLine("2. Module");
                Console.WriteLine("3. Configuration");
                int input = int.Parse(Console.ReadLine());
                if(input == 1)
                {
                    while (true)
                    {
                        Service.ChooseAction();
                        int input1 = int.Parse(Console.ReadLine());
                        if(input1 == 1)
                        {
                            Service.ShowProductsByPart(parts);
                            break;
                        }
                        else if(input1 == 2)
                        {
                            Service.ShowByPriceOfPart(parts);
                            break;
                        }
                        else if(input1 == 3)
                        {
                            Service.ShowByTypeOfPart(parts);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Enter valid action! Press any key.");
                            Console.ReadLine();
                        }
                    }
                    break;   
                }
                else if(input == 2)
                {
                    break;
                }
                else if(input == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not a valid action!");
                    Console.WriteLine("Press any key to try again!");
                    Console.ReadLine();
                }
            }

        }
    }
}
