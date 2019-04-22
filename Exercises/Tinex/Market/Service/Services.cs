using Market.Classes;
using Market.Database;
using Market.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Service
{
	public static class Services
	{
		public static void GetAllItems()
		{
			foreach (var item in Db.allProducts)
			{
				item.PrintProduct();
			}
		}

		public static void FilterItems()
		{
			while (true)
			{
				int input = 0;
				bool flag = false;
				Console.WriteLine("Filter Items By:");
				Console.WriteLine("1. Company");
				Console.WriteLine("2. Type");
				bool result = int.TryParse(Console.ReadLine(), out input);
				if (result)
				{
					if (input != 1 && input != 2)
					{
						Console.WriteLine("Not 1 or 2.Press any key and try again.");
						Console.ReadLine();
						continue;
					}
					else
					{
						if(input == 1)
						{
							while (true)
							{
								Console.WriteLine("Enter Name of Company");
								string name = Console.ReadLine();
								var results = Db.allProducts.Where(x => x.Company == name).ToList();
								if (results.Count == 0)
								{
									Console.WriteLine("No such a name!Press any key and try again.");
									Console.ReadLine();
									continue;
								}
								else
								{
									foreach (var item in results)
									{
										item.PrintProduct();
									}
									flag = true;
									break;
								}
							}
						}
						else if(input == 2)
						{
							while (true)
							{
								Console.WriteLine("Enter the name of the Type of the Product:");
								Console.WriteLine("Meat");
								Console.WriteLine("Fruit");
								Console.WriteLine("Vegetables");
								Console.WriteLine("Beverages");
								Console.WriteLine("------------");
								string name = Console.ReadLine();
								ProductType types = (ProductType)System.Enum.Parse(typeof(ProductType), name);
								var results = Db.allProducts.Where(x => x.Type == types).ToList();
								if (results.Count == 0)
								{
									Console.WriteLine("No such a name!Press any key and try again.");
									Console.ReadLine();
									continue;
								}
								else
								{
									foreach (var item in results)
									{
										item.PrintProduct();
									}
									flag = true;
									break;
								}
							}
						}
					}
					if (flag)
						break;
				}
				else
				{
					Console.WriteLine("Enter valid format (number expected).Press any key and try again.");
					Console.ReadLine();
					continue;
				}
			}
		}

		public static void GetItemById()
		{
			while (true)
			{
				int input = 0;
				Console.WriteLine("Enter ID of Product:");
				bool result = int.TryParse(Console.ReadLine(),out input);
				if (result)
				{
					var item = Db.allProducts.Where(x => x.Id == input).FirstOrDefault();
					if(item == null)
					{
						Console.WriteLine("There is not such an ID.Press any key and try again!");
						Console.ReadLine();
						continue;
					}
					item.PrintProduct();
					break;
				}
				else
				{
					Console.WriteLine("Not a valid format (number expexted).Press any key and try again!");
					Console.ReadLine();
					continue;
				}
			}
		}

		public static void GetItemsByPrice()
		{
			while (true)
			{
				int min = 0;
				int max = 0;
				Console.WriteLine("Enter Minimum Price more than 29:");
				bool result1 = int.TryParse(Console.ReadLine(), out min);
				Console.WriteLine("Enter Maximum Price not greater than 257:");
				bool result2 = int.TryParse(Console.ReadLine(), out max);
				if(result1 && result2)
				{
					if(min > max)
					{
						Console.WriteLine("Minimum is greater than maximum.Are you normal? Press any key and try again!");
						Console.ReadLine();
						continue;
					}
					else if(min < 30 || max > 257)
					{
						Console.WriteLine("Not a valid minimum or maximum value. Press any key and try again!");
						Console.ReadLine();
						continue;
					}
					else
					{
						var results = Db.allProducts.Where(x => x.Price >= min && x.Price <= max).ToList();
						foreach (var item in results)
						{
							item.PrintProduct();
						}
						break;
					}
				}
				else
				{
					Console.WriteLine("Not a valid format (number expexted).Press any key and try again!");
					Console.ReadLine();
					continue;
				}
			}
		}

		public static void SortItems()
		{
			int input = 0;
			Console.WriteLine("Sort Items By:");
			Console.WriteLine("1. Copmany Name");
			Console.WriteLine("2. ID");
			Console.WriteLine("3. Price");

			bool result = int.TryParse(Console.ReadLine(), out input);
		}
	}
}
