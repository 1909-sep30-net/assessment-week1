using System;

namespace Palindrome.Library
{
    public class Pali
    {
        public bool IsPalindrome(string value)
        {
            int i = 0;
            int n = value.Length - 1;

            while (i != n)
            {
                char x = value[i];
                char y = value[n];
                if (Char.ToLower(x) != Char.ToLower(y))
                {
                    return false;
                }
                i++;
                n--;

            }
            return true;

        }
    }
}
