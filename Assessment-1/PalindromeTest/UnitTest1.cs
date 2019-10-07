using System;
using Xunit;
using Palindrome.Library;
using System.Text.RegularExpressions;

namespace PalindromeTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("nurses Run")]
        [InlineData(" v        ")]
        public void RemoveWhiteSpaceShouldRemoveWhiteSpace(string s)
        {
            //Arrange
            var p = new PChecker();
            string test = p.RemoveWhiteSpace(s);

            Assert.Equal(egex.Replace(s, @"s", ""),  test);
        }

        [Theory]
        [InlineData("nurses Run")]
        [InlineData(" v        ")]
        public void ReverseStringShouldReverse(string s) {
            var p = new PChecker();
            string test = p.ReverseString(s);
            char[] arr = s.ToCharArray();
            Array.Reverse(arr)

            Assert.Equal(new string(arr),test);
        }
        [Fact]
        public void CheckPalindromeShouldCheckPalindrome()
        {
            string s = "nurses Run";
            var p = new PChecker();
            Assert.Equal(true, p.CheckPalindrome(s));
        }

    }
}
