using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // INTEGER
            int number = 121;
            Console.WriteLine(number.IsPalindromeInt());
            // LONG
            long number1 = 12345654321;
            Console.WriteLine(number1.IsPalindromeLong());
            // DOUBLE
            double number2 = 123.321;
            Console.WriteLine(number2.IsPalindromeDouble());
            // STRING
            string phrase;
            phrase = "Madam, I'm Adam";
            Console.WriteLine(phrase.VerifyPalindrome());
            phrase = "Madam, I am Adam";
            Console.WriteLine(phrase.VerifyPalindrome());
            phrase = "Refer, refer!";
            Console.WriteLine(phrase.VerifyPalindrome());

            Console.ReadLine();
        }
    }
}
