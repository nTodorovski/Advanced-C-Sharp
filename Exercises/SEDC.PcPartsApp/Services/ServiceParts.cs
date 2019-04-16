using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class ServiceParts
    {
        public static void ChooseAction()
        {
            Console.WriteLine("Choose Action:");
            Console.WriteLine("1. Show Products");
            Console.WriteLine("2. By Price");
            Console.WriteLine("3. By Type");
        }

        public static void ShowProductsByPart(List<Part> items)
        {
            foreach (var part in items)
            {
                Console.WriteLine($"Name: {part.Name}");
            }
        }

        public static void ShowByPriceOfPart(List<Part> items)
        {
            while (true)
            {
                int min = 0;
                int max = 0;
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Lowest is 8 dollars, Highest is 1500. Enter between these numbers:");
                    Console.WriteLine("Enter minimum price of Part:");
                    min = int.Parse(Console.ReadLine());
                    if (min < 8 || min > 1500)
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
                    if (max < min || max > 1500)
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
                    Console.WriteLine("There are no parts in that range!Please try again.Press any key.");
                    Console.ReadLine();
                    continue;
                }
                Console.Clear();
                foreach (var item in itemList)
                {
                    Console.WriteLine($"Name: {item.Name}, Price: {item.Price}");
                }
                break;
            }
        }

        public static void ShowByTypeOfPart(List<Part> parts)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose the type of part");
                Console.WriteLine("1.CPU");
                Console.WriteLine("2.CpuCooler");
                Console.WriteLine("3.Gpu");
                Console.WriteLine("4.GpuCooler");
                Console.WriteLine("5.Case");
                Console.WriteLine("6.PowerSuply");
                Console.WriteLine("7.MotherBoard");
                Console.WriteLine("8.ConnectionCable");
                Console.WriteLine("9.PowerCable");
                Console.WriteLine("10.SSD");
                Console.WriteLine("11.HDD");
                Console.WriteLine("12.RAM");
                Console.WriteLine("13.Monitor");
                Console.WriteLine("14.Mouse");
                Console.WriteLine("15.Keyboard");
                bool flag = true;
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        ShowTypes(input, parts);
                        break;
                    case 2:
                        ShowTypes(input, parts);
                        break;
                    case 3:
                        ShowTypes(input, parts);
                        break;
                    case 4:
                        ShowTypes(input, parts);
                        break;
                    case 5:
                        ShowTypes(input, parts);
                        break;
                    case 6:
                        ShowTypes(input, parts);
                        break;
                    case 7:
                        ShowTypes(input, parts);
                        break;
                    case 8:
                        ShowTypes(input, parts);
                        break;
                    case 9:
                        ShowTypes(input, parts);
                        break;
                    case 10:
                        ShowTypes(input, parts);
                        break;
                    case 11:
                        ShowTypes(input, parts);
                        break;
                    case 12:
                        ShowTypes(input, parts);
                        break;
                    case 13:
                        ShowTypes(input, parts);
                        break;
                    case 14:
                        ShowTypes(input, parts);
                        break;
                    case 15:
                        ShowTypes(input, parts);
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

        public static void ShowTypes(int number, List<Part> parts)
        {
            foreach (var item in parts)
            {
                if ((int)item.Type == number)
                {
                    Console.WriteLine($"Name: {item.Name}, Type: {item.Type}");
                }
            }
        }
    }
}
