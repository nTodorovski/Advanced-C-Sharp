using System;

namespace InterfacesDemo
{
    public class Cat : IPredator
    {
        public int AttackSpeed { get; set; }
        public string Name { get; set; }

        public void Attack(IPray pray)
        {
            if (this.AttackSpeed > pray.FleeSpeed)
            {
                Console.WriteLine(this.Name + " catches " + pray.Name);
            }
            else
            {
                Console.WriteLine(pray.Name + " escapes from " + this.Name);
            }
        }
    }
}