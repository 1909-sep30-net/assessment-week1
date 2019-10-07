using System;
using Xunit;

namespace Palindrome.Test
{
    public class PalindromeTest
    {
        [Fact]
        public void IsPalindromeTestIsPalindrome()
        {
            bool isRacecarTrue = Palindrome.IsPalindrome("racecar");
            bool isIcecreamTrue = Palindrome.IsPalindrome("ice cream");

            Assert.True(isRacecarTrue);
            Assert.False(isIcecreamTrue);
        }
    }
}
