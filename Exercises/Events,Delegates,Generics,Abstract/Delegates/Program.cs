using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        public delegate bool SayDelegate(string str1,string str2);

        public static bool StringMagic(string str1,string str2)
        {
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            return true;
        }

        public static bool StringMagicCompare(string str1,string str2)
        {
            if (str1.Length > str2.Length)
                return true;
            return false;
        }

        static void Main(string[] args)
        {

            SayDelegate say = new SayDelegate(StringMagic);
            SayDelegate compare = new SayDelegate((string s, string l) => 
            {
                if (s.Length > l.Length) return true; return false;
            });
            SayDelegate firstSameChar = new SayDelegate((string str1, string str2) => 
            {
                if (str1[0] == str2[0])
                    return true;
                return false;
            });
            SayDelegate lastSameChar = new SayDelegate((string str1, string str2) =>
            {
                if (str1[str1.Length - 1] == str2[str2.Length - 1])
                    return true;
                return false;
            });

            Func<int, bool> myFunc = (x) => false; 

            say("hello", "viktor");
            compare("hellllllo", "hello");
            firstSameChar("kniga", "kokoska");
            lastSameChar("petko", "trajko");
        }
    }
}
