using System;

namespace palindromQuiz
{
    public class Class1
    {

        public bool Checked(string pal)
        {
            string first = pal.Substring(0, pal.Length / 2);
            char[] arr = pal.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            return first.Equals(second);
        }
    }
}
