using System.Linq;

namespace Palindrome
{
    public class Palindrome
    {
        public static bool IsPalindrome(string str)
        {
            string stringWithoutWhiteSpace = str.Replace(" ", "");
            string reversedString = new string(stringWithoutWhiteSpace.Reverse().ToArray());

            return string.Compare(stringWithoutWhiteSpace, reversedString) == 0;
        }
    }
}