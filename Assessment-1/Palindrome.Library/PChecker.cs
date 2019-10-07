using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Palindrome.Library
{
    public class PChecker
    {
        public bool CheckPalindrome(String s) {
            //removes whitespace
            RemoveWhiteSpace(s);

            //reverses string
            string srev = ReverseString(s);

            if (srev.Equals(s, StringComparison.OrdinalIgnoreCase)) return true;
            return false;
        }
        public string RemoveWhiteSpace(string s) 
        {
            //removes any whitespace from string to easily compare it
            return Regex.Replace(s, @"s", "");
        }
        public string ReverseString(string s)
        {
            //reverses string 
            char[] chck = s.ToCharArray();
            Array.Reverse(chck);
            return new string(chck);
        }
    }
}
