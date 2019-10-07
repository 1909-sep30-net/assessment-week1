using System;

namespace Assessment.Library
{
    public class PalindromClass
    {

        public string MainString { get; set; }

        public bool CheckPalindrom()
        {
            string tempString = MainString;
            tempString = MainString.Replace(" ", "");
            tempString = tempString.Replace(",", "");
            string reversedString = "";
            int length;

            length = tempString.Length - 1;

            while (length >= 0)
            {
                reversedString = reversedString + tempString[length];
                length--;
            }

            Console.WriteLine(reversedString);

            if(tempString.ToLower() == reversedString.ToLower())
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
