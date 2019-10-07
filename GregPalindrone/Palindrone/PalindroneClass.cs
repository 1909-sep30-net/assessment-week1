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

        public bool isPalindrone()
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
                    if(textArray[i] != textArray[j])
                    {
                        return false;
                    }
                }
                i++;
                j--;
            }
            return true;
        }
    }
}
