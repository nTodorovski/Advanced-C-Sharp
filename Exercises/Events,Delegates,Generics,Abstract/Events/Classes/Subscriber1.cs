using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Classes
{
    public class Subscriber1
    {
        public void Sms(string str)
        {
            Console.WriteLine($"I got the the message through SMS with the message: {str}");
        }
    }
}
