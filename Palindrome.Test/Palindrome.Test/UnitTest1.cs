using System;
using Xunit;
using Palindrome.Library;

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
            var seq = new Palindrome();

            pal.CheckIfPalindrome(item);

            Assert.True(true);
        }
        [Theory]
        [InlineData("test")]
        [InlineData("Fail")]
        public void CheckIfPalindromReturnFalse(string item)
        {
            var seq = new Palindrome();

            pal.CheckIfPalindrome(item);

            Assert.True(false);
        }

    }
}
