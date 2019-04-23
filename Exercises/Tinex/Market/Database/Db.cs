using Market.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Database
{
	public static class Db
	{
        public static List<User> users = new List<User>()
        {
            new User("mart2402"),
            new User("hakd2402"),
            new User("pero2402"),
            new User("kiro2402"),
            new User("mirko2402"),
            new User("stanko2402")
        };

		public static List<Item> allProducts = new List<Item>()
		{
			new Meat(1,123,"Pilesko","Pekabesko"),
			new Meat(2,234,"Telesko","Soleta"),
			new Meat(3,257,"Svinsko","Mega"),
			new Fruit(4,60,"Jabolko","Skopski Pazar"),
			new Fruit(5,70,"Mango","Zeleno Pazarce"),
			new Fruit(6,90,"Limon","Vero"),
			new Vegetables(7,55,"Paradajs","Bunjakovec"),
			new Vegetables(8,30,"Marula","Zeleno Pazarce"),
			new Vegetables(9,80,"Krastavica","BitPazar"),
			new Beverages(10,85,"Cola","CocaCola"),
			new Beverages(11,65,"Gazoza","Prilepska Pivara"),
			new Beverages(12,35,"Cedevita","Cedevita")
		};
	}
}
