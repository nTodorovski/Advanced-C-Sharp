using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class UiService
    {
        public static bool NextAction<T>(Func<List<T>, List<Part>, List<Module>, List<Configuration>, bool> method, List<T> items, List<Part> cartP, List<Module> cartM, List<Configuration> cartC)
        {
            while (true)
            {
                Console.WriteLine("Choose Action:");
                Console.WriteLine("1. Continue Shopping");
                Console.WriteLine("2. Choose something else");
                Console.WriteLine("3. See Cart");
                Console.WriteLine("4. Continue to Check Out");

                int input = int.Parse(Console.ReadLine());
                if (input < 1 || input > 4)
                {
                    Console.WriteLine("Not a valid number.Press any key and try again!");
                    Console.ReadLine();
                    continue;
                }

                if (input == 1)
                {
                    method(items, cartP, cartM, cartC);
                }
                else if (input == 2)
                {
                    return false;
                }
                else if (input == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Your Cart:");
                    foreach (var item in cartP)
                    {
                        Console.WriteLine($"Name: {item.Name}");
                    }
                    foreach (var item in cartM)
                    {
                        Console.WriteLine($"Name: {item.Type}");
                    }
                    foreach (var item in cartC)
                    {
                        Console.WriteLine($"Name: {item.Title}");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
