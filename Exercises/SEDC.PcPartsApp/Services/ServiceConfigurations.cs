using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Services
{
    public class ServiceConfigurations
    {
        public static bool ShowProductsByConfigurations(List<Configuration> configurations, List<Part> cartP, List<Module> cartM, List<Configuration> cartC)
        {
            while (true)
            {
                int counter = 1;
                Console.Clear();
                foreach (var configuration in configurations)
                {
                    Console.WriteLine($"{counter}. Configuration Name: {configuration.Title}");
                    counter++;
                    Console.WriteLine();
                    foreach (var module in configuration.Modules)
                    {
                        Console.WriteLine($"Module Name: {module.Type}");
                        foreach (var part in module.Parts)
                        {
                            Console.WriteLine($"Part: {part.Name}");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("--------------------------------");
                }
                Console.WriteLine("Choose product to buy:");
                int input = int.Parse(Console.ReadLine());
                if (input < 1 || input > counter)
                {
                    Console.WriteLine("Enter valid number. Press any key and try again!");
                    Console.ReadLine();
                    continue;
                }
                else
                {
                    cartC.Add(configurations[input - 1]);
                    var boughtPart = configurations[input - 1];
                    Console.WriteLine($"Product of type: {boughtPart.Type} {boughtPart.Title} is added to your cart!");
                    var nesto = UiService.NextAction(ShowProductsByConfigurations, configurations, cartP, cartM, cartC);
                    return nesto;
                }
            }
        }

        public static void ShowByPriceOfConfigurations(List<Configuration> configurations)
        {
            while (true)
            {
                int min = 0;
                int max = 0;
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Lowest is 800 dollars, Highest is 1800. Enter between these numbers:");
                    Console.WriteLine("Enter minimum price of Part:");
                    min = int.Parse(Console.ReadLine());
                    if (min < 800 || min > 1800)
                    {
                        Console.WriteLine("Enter valid number.Press any key.");
                        Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Enter maximum price of Part:");
                    max = int.Parse(Console.ReadLine());
                    if (max < min || max > 1800)
                    {
                        Console.WriteLine("Enter valid number.Press any key.");
                        Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                var itemList = configurations.Where(x => x.Price > min && x.Price < max).ToList();

                if (itemList.Count == 0)
                {
                    Console.WriteLine("There are no parts in that range!Please Try again. Press any key!");
                    Console.ReadLine();
                    continue;
                }
                Console.Clear();
                foreach (var item in itemList)
                {
                    Console.WriteLine($"Name: {item.Title}, Price: {item.Price}");
                }
                break;
            }
        }

        public static void ShowByTypeOfConfigurations(List<Configuration> configurations)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose the type of part");
                Console.WriteLine("1.Standard");
                Console.WriteLine("2.Office");
                Console.WriteLine("3.Gaming");

                bool flag = true;
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        ShowTypes(input, configurations);
                        break;
                    case 2:
                        ShowTypes(input, configurations);
                        break;
                    case 3:
                        ShowTypes(input, configurations);
                        break;
                    default:
                        Console.WriteLine("Not a valid number.Please try again.");
                        flag = false;
                        break;
                }
                if (!flag)
                    continue;
                break;
            }
        }


        public static void ShowTypes(int number, List<Configuration> configurations)
        {
            foreach (var item in configurations)
            {
                if ((int)item.Type == number)
                {
                    Console.WriteLine($"Type: {item.Type} Price: {item.Price}");
                }
            }
        }
    }
}
