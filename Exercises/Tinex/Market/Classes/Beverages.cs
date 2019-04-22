using Market.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Classes
{
	public class Beverages : Item
	{
		public Beverages(int id, double price, string name, string company) : base(id, price, name, company)
		{
			Type = ProductType.Beverages;
		}
	}
}
