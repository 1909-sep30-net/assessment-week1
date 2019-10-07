using System;

namespace assessmentWeek1.Library
{
    class PalindromeTest
    {
        public static bool PaliTest(string palindrome)
        {
            string firstHalf = palindrome.Substring(0, palindrome.Length / 2);
            char[] arr = palindrome.ToCharArray();

            Array.Reverse(arr);

            string reverse = new string(arr);
            string secondHalf = reverse.Substring(0, reverse.Length / 2);

            return firstHalf.Equals(secondHalf);
        }
    }
    }
}
