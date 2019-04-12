using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Classes
{
    public class Subscriber2
    {
        public void EMail(string str)
        {
            Console.WriteLine($"I got the the message through E-Mail with the message: {str}");
        }
    }
}
