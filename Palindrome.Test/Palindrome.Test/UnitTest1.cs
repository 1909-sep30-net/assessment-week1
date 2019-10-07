using System;
using Xunit;
using Palindrome;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Palindrome.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData ("racecar")]
        [InlineData ("abcba")]
        [InlineData ("never odd, or even")]
        public void CheckIfPalindromeReturnTrue(string item)
        {
            var pal = new Palindrome();
            pal.CheckIfPalindrome(item);

            Assert.True(pal.CheckIfPalindrome(item) == true);
        }
        [Theory]
        [InlineData("test")]
        [InlineData("Fail")]
        public void CheckIfPalindromReturnFalse(string item)
        {
            var pal = new Palindrome();

            Assert.False(pal.CheckIfPalindrome(item) == false);
        }

    }
}
