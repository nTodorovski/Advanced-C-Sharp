using Market.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Classes
{
	public abstract class Item
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public	double Price { get; set; }
		public string Company { get; set; }
		public ProductType Type { get; set; }

		public Item(int id,double price,string name,string company)
		{
			Id = id;
			Price = price;
			Name = name;
			Company = company;
		}

		public void PrintProduct()
		{
			Console.WriteLine($"ID: {Id}\t Price: {Price}\t Name: {Name}\t Company: {Company}\t Type: {Type}");
		}
	}
}
