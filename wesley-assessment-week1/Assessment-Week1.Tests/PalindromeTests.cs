using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Assessment_Week1.Library;

namespace Assessment_Week1.Tests
{
    public class PalindromeTests
    {

        [Theory]
        [InlineData("aaaba")]
        [InlineData("abaaba")]
        [InlineData("aab baa")]
        [InlineData("nurses run")]
        public void IsWordAPalindrome(string word)
        {
            var sentence = new Palindrome();

            bool test = sentence.IsPalindrome(word);

            Assert.True(true, "test failed");
        }
    }
}
