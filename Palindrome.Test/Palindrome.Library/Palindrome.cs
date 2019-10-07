using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindrome.Library
{
    public class Palindrome
    {
        public string input {get; set;}
        public void CheckIfPalindrome(string input)
        {
            input = this.input;
            //variable initialization
            char[] charArray;
            string firstHalf;
            string secondHalf;
            bool check = false;

            //puts string in char array
            charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversedArray = new string(charArray);

            //Makes the half strings for the comparison
            firstHalf = input.Substring(0, input.Length/2);
            secondHalf = input.Substring(0, reversedArray.Length / 2);

            //if the first half of the thing matches the back half of it (reversed)
                //return true
            //else
                //return false

            if (firstHalf == secondHalf)
            {
                check = true;
            }
            else
            {
                check = false;
            }

            return check;


        }
    }
}
