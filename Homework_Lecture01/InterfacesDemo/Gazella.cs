using System;

namespace InterfacesDemo
{
    public class Gazella : IPray
    {
        public int FleeSpeed { get; set; }
        public string Name { get; set; }

        public void Flee()
        {
            Console.WriteLine(this.Name + " flees away...");
        }
    }
}