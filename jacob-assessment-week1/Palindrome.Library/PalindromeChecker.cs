using System;
using System.Text;

namespace Palindrome.Library
{
    public class PalindromeChecker
    {
        public static string CleanString(string input)
        {
            // Remove all punctuation and spaces.
            StringBuilder sb = new StringBuilder(); ;

            for (int i = 0; i < input.Length; ++i)
            {
                if (!char.IsPunctuation(input[i]) && input[i] != ' ')
                {
                    sb.Append(char.ToLower(input[i]));
                }
            }

            return sb.ToString();
        }

        public static bool IsPalindrome(string subject)
        {
            string clean = CleanString(subject);

            for (int i = 0; i < clean.Length/2; ++i)
            {
                if (clean[i] != clean[clean.Length - i - 1])
                    return false;
            }

            return true;
        }
    }
}
