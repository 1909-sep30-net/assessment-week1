using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrone
{
    public class PalindroneClass
    {
        public string Text { get; set; }

        public PalindroneClass(string text)
        {
            Text = text;
        }

        public static bool isPalindrone()
        {
            char[] textArray = Text.ToCharArray();
            int i = 0;
            int j = textArray.Length - 1;

            while(i < j)
            {
                while(Char.IsPunctuation(textArray[i]) || Char.IsWhiteSpace(textArray[i]))
                {
                    i++;
                }
                while (Char.IsPunctuation(textArray[j]) || Char.IsWhiteSpace(textArray[j]))
                {
                    j--;
                }
                if(i < j)
                {
                    if(i != j)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
