using Market.Database;
using Market.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.Clear();
				Console.WriteLine("Choose Action:");
				Console.WriteLine("1. Get All Items");
				Console.WriteLine("2. Filter Items");
				Console.WriteLine("3. Get Item By Id");
				Console.WriteLine("4. Get Items in Price Range");
				int input = 0;
				bool result = int.TryParse(Console.ReadLine(), out input);
				if (result)
				{
					if(input == 1)
					{
						Services.GetAllItems();
					}
					else if(input == 2)
					{
						Services.FilterItems();
					}
					else if(input == 3)
					{
						Services.GetItemById();
					}
					else if(input == 4)
					{
						Services.GetItemsByPrice();
					}
					else
					{
						Console.WriteLine("Not a valid number of action. Press any key and try again!");
						Console.ReadLine();
						continue;
					}
				}
				else
				{
					Console.WriteLine("Not a valid format (number expexted).Press any key and try again!");
					Console.ReadLine();
					continue;
				}

				Console.WriteLine("Do you want to continue? Y/N");
				string action = Console.ReadLine().ToLower();
				if(action == "y")
				{
					continue;
				}
				else
				{
					break;
				}
			}
		}
	}
}
