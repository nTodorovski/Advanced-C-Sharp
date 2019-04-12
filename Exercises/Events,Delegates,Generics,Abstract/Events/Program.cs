using Events.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Trainer trainer = new Trainer();
            Subscriber1 sub1 = new Subscriber1();
            Subscriber2 sub2 = new Subscriber2();
            Subscriber3 sub3 = new Subscriber3();

            trainer.Eventce += sub1.Sms;
            trainer.Eventce += sub2.EMail;
            trainer.Eventce += sub3.Fb;
            //dragan.friends += user.nikola;
            //dragan.Post(slika); // nikola ke ja dobie na feed
            List<string> strings = new List<string>() { "petko", "trajko"};
            Func<string, bool> myFunc = x => false;
            strings.Where(myFunc);
            
            trainer.ComposeMessage("Pero", 4, "Poraka");
            
            trainer.Eventce += sub1.Sms;
            trainer.Eventce -= sub2.EMail;

            trainer.ComposeMessage("Pero", 4, "Poraka");
            Console.ReadLine();
        }
    }
}
