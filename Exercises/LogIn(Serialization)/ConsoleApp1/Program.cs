using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            UserService userService = new UserService();
            while (true)
            {
                Console.WriteLine("Choose Action:");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Log In");
                int result = int.Parse(Console.ReadLine());
                if (result == 1)
                {
                    userService.Register();
                }
                else if (result == 2)
                {
                    userService.LogIn();
                }
                else
                {
                    Console.WriteLine("Did not entered valid action!");
                }
            }
        }
    }
}
