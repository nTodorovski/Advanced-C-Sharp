using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class ServiceModules
    {
        public static void ShowProductsByModules(List<Module> items)
        {
            foreach (var module in items)
            {
                Console.WriteLine($"Type: {module.Type}");
                foreach (var item in module.Parts)
                {
                    Console.WriteLine($"Part: {item.Name}");
                }
                Console.WriteLine("-----------------------------");
            }
        }

        public static void ShowByPriceOfModules(List<Module> items)
        {
            while (true)
            {
                int min = 0;
                int max = 0;
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Lowest is 100 dollars, Highest is 840. Enter between these numbers:");
                    Console.WriteLine("Enter minimum price of Module:");
                    min = int.Parse(Console.ReadLine());
                    if (min < 100 || min > 840)
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
                    if (max < min || max > 840)
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
                var itemList = items.Where(x => x.Price > min && x.Price < max).ToList();
                if(itemList.Count == 0)
                {
                    Console.WriteLine("There are no parts in that range! Please try again.Press any key.");
                    Console.ReadLine();
                    continue;
                }
                Console.Clear();
                foreach (var item in itemList)
                {
                    Console.WriteLine($"Name: {item.Type}, Price: {item.Price}");
                }
                break;
            }
        }

        public static void ShowByTypeModules(List<Module> modules)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose the type of part");
                Console.WriteLine("1.Processing");
                Console.WriteLine("2.Graphics");
                Console.WriteLine("3.Casing");
                Console.WriteLine("4.MainBoard");
                Console.WriteLine("5.Memory");
                Console.WriteLine("6.Other");
                bool flag = true;
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        ShowTypes(input, modules);
                        break;
                    case 2:
                        ShowTypes(input, modules);
                        break;
                    case 3:
                        ShowTypes(input, modules);
                        break;
                    case 4:
                        ShowTypes(input, modules);
                        break;
                    case 5:
                        ShowTypes(input, modules);
                        break;
                    case 6:
                        ShowTypes(input, modules);
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


        public static void ShowTypes(int number, List<Module> modules)
        {
            foreach (var item in modules)
            {
                if ((int)item.Type == number)
                {
                    Console.WriteLine($"Type: {item.Type} Price: {item.Price}");
                }
            }
        }
    }
}
