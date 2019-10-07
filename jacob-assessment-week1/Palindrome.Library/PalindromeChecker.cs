using System;
using System.Text;

namespace Palindrome.Library
{
    public class PalindromeChecker
    {
        /// <summary>
        /// Removes all punctuation and spaces from a string.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>A 'cleaned' string with no punctuation or spaces.</returns>
        public static string CleanString(string input)
        {
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

        /// <summary>
        /// Checks whether the given string is a palindrome.
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>True if subject is a palindrome, false otherwise.</returns>
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
