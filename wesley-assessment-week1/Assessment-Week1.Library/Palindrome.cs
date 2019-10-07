using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_Week1.Library
{
    public class Palindrome
    {
        public bool IsPalindrome(string word)
        {
            List<char> a = new List<char>();
            List<char> b = new List<char>();
            for(int i = 0; i < word.Length; i++)
            {
                a.Add(word[i]);
            }
            for(int j = word.Length - 1; j >= 0; j--)
            {
                b.Add(word[j]);
            }
            if (a == b)
            {
                Console.WriteLine("word is a palindrome");
                return true;
            }
            else
            {
                Console.WriteLine("word is not a palindrome");
                return false;
            }
        }
    }
}
