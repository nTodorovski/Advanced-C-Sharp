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
            var configurations = Db.Configurations;
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
                        ServiceParts.ChooseAction();
                        int input1 = int.Parse(Console.ReadLine());
                        if(input1 == 1)
                        {
                            ServiceParts.ShowProductsByPart(parts);
                            break;
                        }
                        else if(input1 == 2)
                        {
                            ServiceParts.ShowByPriceOfPart(parts);
                            break;
                        }
                        else if(input1 == 3)
                        {
                            ServiceParts.ShowByTypeOfPart(parts);
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
                    while (true)
                    {
                        ServiceParts.ChooseAction();
                        int input1 = int.Parse(Console.ReadLine());
                        if (input1 == 1)
                        {
                            ServiceModules.ShowProductsByModules(modules);
                            break;
                        }
                        else if (input1 == 2)
                        {
                            ServiceModules.ShowByPriceOfModules(modules);
                            break;
                        }
                        else if (input1 == 3)
                        {
                            ServiceModules.ShowByTypeModules(modules);
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
                else if(input == 3)
                {
                    while (true)
                    {
                        ServiceParts.ChooseAction();
                        int input1 = int.Parse(Console.ReadLine());
                        if (input1 == 1)
                        {
                            ServiceConfigurations.ShowProductsByConfigurations(configurations);
                            break;
                        }
                        else if (input1 == 2)
                        {
                            ServiceConfigurations.ShowByPriceOfConfigurations(configurations);
                            break;
                        }
                        else if (input1 == 3)
                        {
                            ServiceConfigurations.ShowByTypeOfConfigurations(configurations);
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
