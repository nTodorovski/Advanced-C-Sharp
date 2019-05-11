using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GameService gameService = new GameService();
            gameService.Game();
            Console.ReadLine();
        }
    }
}
