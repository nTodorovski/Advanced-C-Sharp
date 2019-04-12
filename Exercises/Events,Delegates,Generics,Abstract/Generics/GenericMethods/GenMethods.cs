using Animals.Classess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.GenericMethods
{
    public class GenMethods
    {
        public void PrintList<T>(List<T> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintListAnimals<T>(List<T> lista) where T : Animal
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
