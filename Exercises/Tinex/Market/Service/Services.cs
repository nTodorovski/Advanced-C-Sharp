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
        public static double EnterId()
        {
            while (true)
            {
                Console.WriteLine("Enter ID:");
                string input = Console.ReadLine();
                bool flag = false;
                foreach (var item in Db.users)
                {
                    if (item.Id == input)
                    {
                        flag = true;
                        if (item.Id.Contains("mart"))
                        {
                            Console.WriteLine($"Hello {item.Id}. You have 10% discount on all products!");
                            return 0.1;
                        }
                        else
                        {
                            Console.WriteLine($"Hello {item.Id}!");
                        }
                    }
                }
                if (flag == false)
                    Console.WriteLine("No such a user!");
                return 0;
            }
        }

		public static void GetAllItems()
		{
            var popust = EnterId();
            SortItems(Db.allProducts, popust);
		}

		public static void FilterItems()
		{
			while (true)
			{
				int input = 0;
				bool flag = false;
                var popust = EnterId();
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
                                    SortItems(results, popust);
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
                                    SortItems(results, popust);
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
                var popust = EnterId();
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
                        SortItems(results, popust);
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

        public static void AscDsc(List<Item> lista, int input, double popust)
        {
            while (true)
            {
                if(popust > 0)
                {
                    foreach (var item in lista)
                    {
                        item.Price = item.Price - (item.Price * popust);
                    }
                }
                Console.Clear();
                int input1 = 0;
                Console.WriteLine("Choose Action:");
                Console.WriteLine("1. Ascending");
                Console.WriteLine("2. Descending");
                bool result1 = int.TryParse(Console.ReadLine(), out input1);
                if (result1)
                {
                    if (input1 == 1)
                    {
                        if(input == 1)
                        {
                            List<Item> novaLista = lista.OrderBy(x => x.Company).ToList();
                            foreach (var item in novaLista)
                            {
                                item.PrintProduct();
                            }
                            break;
                        }
                        else if(input == 2)
                        {
                            List<Item> novaLista = lista.OrderBy(x => x.Id).ToList();
                            foreach (var item in novaLista)
                            {
                                item.PrintProduct();
                            }
                            break;
                        }
                        else if(input == 3)
                        {
                            List<Item> novaLista = lista.OrderBy(x => x.Price).ToList();
                            foreach (var item in novaLista)
                            {
                                item.PrintProduct();
                            }
                            break;
                        }
                    }
                    else if (input1 == 2)
                    {
                        if (input == 1)
                        {
                            List<Item> novaLista = lista.OrderByDescending(x => x.Company).ToList();
                            foreach (var item in novaLista)
                            {
                                item.PrintProduct();
                            }
                            break;
                        }
                        else if (input == 2)
                        {
                            List<Item> novaLista = lista.OrderByDescending(x => x.Id).ToList();
                            foreach (var item in novaLista)
                            {
                                item.PrintProduct();
                            }
                            break;
                        }
                        else if (input == 3)
                        {
                            List<Item> novaLista = lista.OrderByDescending(x => x.Price).ToList();
                            foreach (var item in novaLista)
                            {
                                item.PrintProduct();
                            }
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not a valid number.Press any key and try again!");
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
            }
        }

		public static void SortItems(List<Item> lista, double popust)
		{
            while (true)
            {
                int input = 0;
                Console.WriteLine("Sort Items By:");
                Console.WriteLine("1. Copmany Name");
                Console.WriteLine("2. ID");
                Console.WriteLine("3. Price");

                bool result = int.TryParse(Console.ReadLine(), out input);
                if (result)
                {
                    if(input == 1 || input == 2 || input == 3)
                    {
                        AscDsc(lista, input, popust);
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
	}
}
