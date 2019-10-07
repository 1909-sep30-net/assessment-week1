using System;
using Xunit;
using Joseph.Week1.Palindrome;

namespace Joseph.week1.PalindromeTest
{
    public class PalindromeTest
    { 
        [Theory]
        [InlineData ("one two one")]
        [InlineData("123abccba123")]
        public void Non_Palindrome_Should_Be_False(string s)
        {
            Palindrome p = new Palindrome();

            Assert.False(p.IsPalindrom(s));
        }

        readonly Palindrome p = new Palindrome();

        [Theory]
        [InlineData("nurses run")]
        [InlineData("racecaR")]
        [InlineData("1221")]
        [InlineData("never odd, or even.")]
        public void Palindrome_Should_Be_True(string s)
        {
            Assert.True(p.IsPalindrom(s));
        }
    }
}
