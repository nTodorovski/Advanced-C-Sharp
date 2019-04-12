using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events.Classes
{
    public class Trainer
    {
        public delegate void Say(string str);
        public event Say Eventce;

        protected void SendMessage(string str)
        {
            if(Eventce != null)
            {
                Eventce(str);
            }
        }

        public void ComposeMessage(string trainerName,int groupNumber,string msg)
        {
            Console.WriteLine("Proccessing data...");
            Thread.Sleep(3000);
            SendMessage($"{trainerName} informs G{groupNumber}: {msg}");
        }
    }
}
