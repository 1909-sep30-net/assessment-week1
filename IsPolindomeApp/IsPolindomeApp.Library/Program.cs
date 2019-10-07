using System;

namespace IsPolindomeApp.Library
{
    public class Polindome
    {
        string originString;

        public Polindome (string originString)
        {
            this.originString = originString;
        }

        public string Replace()
        {
            string testString = originString.Replace(" ", string.Empty);
            testString = testString.Replace(".", string.Empty);
            testString = testString.Replace(",", string.Empty);

            return testString;
        }

        public bool CheckPolidrome( string testString)
        {
            bool result = true;
            int check = testString.Length;
            for (int i = 0; i < check / 2; i++)
            {
                if (testString[i] != testString[check - i - 1])
                {
                    result = false;
                }
            }
            return result;
        }
    }
}
