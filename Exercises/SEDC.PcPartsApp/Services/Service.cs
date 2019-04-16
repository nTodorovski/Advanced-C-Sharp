using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class Service
    {
        public static void ChooseAction()
        {
            Console.WriteLine("Choose Action:");
            Console.WriteLine("1. Show Products");
            Console.WriteLine("2. By Price");
            Console.WriteLine("2. By Type");
        }
        public static void ShowProductsByPart(List<Part> items)
        {
            foreach (var part in items)
            {
                Console.WriteLine($"Name:{part.Name}\tType: {part.Type.ToString()}\tPrice: {part.Price}\tCompany: {part.Company}\tQuantity: {part.Quantity}\tWarranty: {part.Warranty}");
            }
        }

        public static void ShowByPriceOfPart(List<Part> items)
        {
            Console.WriteLine("Lowest is 8 dollars, Highest is 1500. Enter between these numbers:");
            int min = 0;
            int max = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter minimum price of Part:");
                min = int.Parse(Console.ReadLine());
                if(min < 8 || min > 1500)
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
                if (max < 8 || max > 1500)
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
            foreach (var item in itemList)
            {
                Console.WriteLine(item.Price);
            }
        }

        public static void ShowByTypeOfPart(List<Part> items)
        {
            int counter = 0;
            foreach (var item in items)
            {
                Console.WriteLine($"{counter}. {item.Type.ToString()}");
                counter++;
            }
            Console.WriteLine("Select Type:");
            Console.ReadLine();
        }
    }
}
