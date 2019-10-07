using System;
using System.Collections.Generic;
using System.Text;

namespace palindrome
{
    //Not done yet
    class CheckPal
    {
        public string front = "";
        public string back;
        public string Check (string s)
        {
            for (int i = 0; i <s.Length; i++)
            {
                char a = s[i];
                front = front + a;
                front += a;
            }
            
            for(int j = s.Length; j != 0; j--)
            {
                char b = s[j];
                back = back + b;
                back += b;
            }          

            if(front == back)
            {
                return "Is a palindrome";
            }
    
            return "Is not palindrome";
        }
    }
}
