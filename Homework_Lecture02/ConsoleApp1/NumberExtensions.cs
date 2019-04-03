using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class NumberExtensions
    {
        public static bool IsPalindromeInt(this int number)
        {
            int r, sum = 0, temp;
            temp = number;
            while (number > 0)
            {
                r = number % 10;
                sum = (sum * 10) + r;
                number = number / 10;
            }
            if (temp == sum)
                return true;
            else
                return false;
        }

        public static bool IsPalindromeLong(this long number)
        {
            long r, sum = 0, temp;
            temp = number;
            while (number > 0)
            {
                r = number % 10;
                sum = (sum * 10) + r;
                number = number / 10;
            }
            if (temp == sum)
                return true;
            else
                return false;
        }

        public static bool IsPalindromeDouble(this double number)
        {
            List<Char> niza = new List<char>();
            var numbers = number.ToString().ToCharArray();
            foreach (var item in numbers)
            {
                niza.Add(item);
            }

            for (int i = 0; i < niza.Count; i++)
            {
                for (int j = niza.Count - 1; j > 0; j--)
                {
                    if (niza[i] != niza[j])
                        return false;
                    i++;
                }
            }
            return true;
        }
    }
}
