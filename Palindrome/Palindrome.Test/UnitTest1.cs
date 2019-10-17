using System;
using Xunit;
using Palindrome.Library;

namespace Palindrome.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("aba")]
        [InlineData("momma")]
        public void test1(string value)
        {
            Pali p = new Pali();
            Assert.True(p.IsPalindrome(value));

        }
    }
}
