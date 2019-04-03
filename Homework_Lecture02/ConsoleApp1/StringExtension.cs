using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class StringExtension
    {
        public static bool VerifyPalindrome(this string word)
        {
            List<char> chars = new List<char>();
            chars.AddRange(word.ToLower().Replace(" ", ""));

            for (int k = 0; k < chars.Count; k++)
            {
                if(char.IsWhiteSpace(chars[k]) || chars[k] == '!' || chars[k] == ',' || chars[k] == '.' || chars[k] == '\'')
                {
                    chars.Remove(chars[k]);
                }
            }

            int i = 0;
            int j = chars.Count - 1;
            while (true)
            {
                if (i > j)
                {
                    return true;
                }
                char a = chars[i];
                char b = chars[j];
                if (a != b)
                {
                    return false;
                }
                i++;
                j--;
            }
        }
    }
}
