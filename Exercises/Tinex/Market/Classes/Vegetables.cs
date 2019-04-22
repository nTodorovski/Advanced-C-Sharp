using Market.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Classes
{
	public class Vegetables : Item
	{
		public Vegetables(int id, double price, string name, string company) : base(id, price, name, company)
		{
			Type = ProductType.Vegetables;
		}
	}
}
