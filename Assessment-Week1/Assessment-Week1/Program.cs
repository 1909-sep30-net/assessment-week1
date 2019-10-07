using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_Week1
{
    class Program
    {
        int winner = 0;

        static void Main(string[] args)
        {
            Program colton = new Program();
            Console.WriteLine(colton.CheckPalindrome("colton"));
            Console.WriteLine(colton.CheckPalindrome("racecar"));

        }
        public bool CheckPalindrome(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i - 1] == input[input.Length - i])
                {
                    winner = winner + 1;
                }
            }
            if (winner == input.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
