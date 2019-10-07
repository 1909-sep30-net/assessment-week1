using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Library
{
    public class PalindromeString
    {
        public bool IsPalindromeString(string input)
        {
            int length = input.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (input[i]!= input[length - i - 1])
                    return false;
            }
            return true;

        }
    }
}
