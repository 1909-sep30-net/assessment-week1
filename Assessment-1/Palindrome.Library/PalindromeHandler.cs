using System;

namespace Palindrome.Library
{
    public class PalindromeHandler
    {
        public Boolean isPalin(string testWord)
        {
            string forwardWord = testWord;

            char[] forwardArr;
            forwardArr = forwardWord.ToCharArray(0, forwardWord.Length);

            
            int count = 0;

            string backwordWord;

            for (int i = forwardArr.Length-1; i >= 0; i--)
            {
                Console.WriteLine(forwardArr[i]);
                //backwordWord =+ forwardArr[i];
                count++;
            }

            char[] backwordArr;
            backwordArr.toCharArray(0, backwordWord.Length);

            int checkCount = 0;
            for (int i = forwardArr.Length - 1; i >= 0; i--)
            {
                if (forwardArr[i] != backwordArr[checkCount])
                {
                    return false;
                }
                checkCount++;
            }
            return false;
        }
    }
}
