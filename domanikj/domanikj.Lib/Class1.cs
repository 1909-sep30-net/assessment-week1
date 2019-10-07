using System;

namespace domanikj.Lib
{
    public class Class1
    {
        public bool IsPalindrome(string value)
        {
            int minimun  = 0;
            int maximun = value.Length - 1;
            while (true)
            {
                if (minimun > maximun)
                {
                    return true;
                }
                char first = value[minimun];
                char second = value[maximun];
                if (char.ToLower(first) != char.ToLower(second))
                {
                    return false;
                }
                minimun++;
                maximun--;
            }
        }
    }
}
