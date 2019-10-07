using System;

namespace StringChecker.Library
{
    public class Palindrome
    {

        public bool CheckForPalindrome (string s)
        {
            string smallS = s.ToLower();
            //smallS.Replace('.', ' ');
            //smallS.Replace(',', ' ');
            char[] arrayS = smallS.ToCharArray();
            Array.Reverse(arrayS);
            if(arrayS.ToString() == smallS)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
