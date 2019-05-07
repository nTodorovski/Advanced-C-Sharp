using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services
{
    public static class UiService
    {
        public static void ChooseAction()
        {
            Console.Clear();
            Console.WriteLine("Choose Action:");
            Console.WriteLine("1. Show Products");
            Console.WriteLine("2. By Price");
            Console.WriteLine("3. By Type");
        }

        public static int HowMany()
        {
            Console.WriteLine("How many products of that you want to buy?");
            int brojka = 0;
            while (true)
            {
                bool result = int.TryParse(Console.ReadLine(), out brojka);
                if (result)
                {
                    return brojka;
                }
                else
                {
                    Console.WriteLine("Enter valid number.Please try again!");
                    continue;
                }
            }
        }

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
                    var nesto = method(items, cartP, cartM, cartC);
                    if (!nesto)
                    {
                        return false;
                    }
                    else
                    {
                        method(items, cartP, cartM, cartC);
                    }
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
                else if (input == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Products bought:");
                    Console.WriteLine("-------------------------------------------------");
                    foreach (var item in cartP)
                    {
                        Console.WriteLine($"{item.Name} - ({item.Price}$)");
                    }
                    foreach (var item in cartM)
                    {
                        Console.WriteLine($"{item.Type} - ({item.Price}$)");
                    }
                    foreach (var item in cartC)
                    {
                        Console.WriteLine($"{item.Title} - ({item.Price}$)");
                    Console.WriteLine("-------------------------------------------------");
                    }
                    double sum = 0;
                    double partsPrice = cartP.Sum(x => x.Price);
                    Console.WriteLine($"Parts Price - {partsPrice}");
                    double modulesPrice = cartM.Sum(x => x.Price);
                    Console.WriteLine($"Modules Price - {modulesPrice}");
                    double confPrice= cartC.Sum(x => x.Price);
                    Console.WriteLine($"Configuration Price - {confPrice}");
                    sum = partsPrice + modulesPrice + confPrice;
                    Console.WriteLine($"Price of all products = {sum}");
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("Send Reciept via:");
                    Console.WriteLine("1. SMS");
                    Console.WriteLine("2. E-Mail");
                    Console.WriteLine("3. Mail (Post)");
                    cartP.Clear();
                    cartM.Clear();
                    cartC.Clear();
                    while (true)
                    {
                        int action = 0;
                        bool result = int.TryParse(Console.ReadLine(), out action);
                        if (result)
                        {
                            if(action == 1)
                            {
                                Thread.Sleep(3000);
                                Console.WriteLine("Reciept sent via SMS!");
                                break;
                            }
                            else if(action == 2)
                            {
                                Thread.Sleep(3000);
                                Console.WriteLine("Reciept sent via E-Mail!");
                                break;
                            }
                            else if(action == 3)
                            {
                                Thread.Sleep(3000);
                                Console.WriteLine("Reciept sent via Mail (Post)!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Not a valid number! Please try again!");
                                continue;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Not a valid input!");
                            continue;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.Press any key and try again!");
                    Console.ReadLine();
                    continue;
                }
            }
        }
    }
}
