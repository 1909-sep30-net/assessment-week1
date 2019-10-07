using System;
using Xunit;
using StringChecker.Library;

namespace PalindromeCheckerTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string s1 = "nurses  run";
            string s2 = "racecaR";
            string s3 = "never odd, or even.";
            string s4 = "123abccba123";
            var c1 = new Palindrome();
            var c2 = new Palindrome();
            var c3= new Palindrome();
            var c4 = new Palindrome();

            c1.CheckForPalindrome(s1);
            c2.CheckForPalindrome(s2);
            c3.CheckForPalindrome(s3);
            c4.CheckForPalindrome(s4);

            Assert.Equal(true, c1);
            Assert.Equal(true, c2);
            Assert.Equal(true, c3);
            Assert.Equal(false, c4);

        }
    }
}
