using System;
using System.Text;

namespace ClassLibrary2
{
    public class Palindrome
    {


        public string rebuildingString(string testString)
        {
            StringBuilder checkChars = new StringBuilder();

            foreach (char c in testString.ToLower())
            {
                if (c != ' ')
                {
                    checkChars.Append(c);
                }
            }
            string s = checkChars.ToString();
            Console.WriteLine(s);

            //Console.WriteLine(getStatus(s));





            return s;
        }

        public bool GetStatus(string myString)
        {

            string s = rebuildingString(myString);
            string first = s.Substring(0, s.Length / 2);
            char[] arr = s.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            Console.WriteLine(first);
            Console.WriteLine(second);
            return first.Equals(second);
        }

    }



}
