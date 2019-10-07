using System;

namespace ispalendrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string theWord = "";
            IPalendromeTester tester = new PalendromeChecker(theWord);

            bool checkRes = tester.isPalendrome();

            Console.WriteLine($"Is \"{theWord}\" a palendrome?: {tester.isPalendrome() }");
        }
    }
}
