using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Market
	{
		public delegate void PromotionSender(User person,ProductType productType);
		public string Name { get; set; }
		
		public void SendPromotions()
		{
			Console.WriteLine(".............Sending");
			Thread.Sleep(2000);
		}
	}
}
