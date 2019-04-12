using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Classes
{
    public class Subscriber3
    {
        public void Fb(string str)
        {
            Console.WriteLine($"I got the the message through Facebook with the message: {str}");
        }
    }
}
