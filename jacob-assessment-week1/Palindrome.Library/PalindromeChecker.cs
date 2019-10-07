using System;

namespace Palindrome.Library
{
    public class PalindromeChecker
    {
        public static bool IsPalindrome(string subject)
        {
            for (int i = 0; i < subject.Length/2; ++i)
            {
                if (subject[i] != subject[subject.Length - i - 1])
                    return false;
            }

            return true;
        }
    }
}
