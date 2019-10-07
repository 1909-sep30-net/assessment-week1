using System;
using Xunit;


namespace Palindrome.Test
{
    public class UnitTest1
    {
        [Fact]
        public void RacecarShouldBeTrue()
        {
            Program colton = new Program();
            var boo = colton.CheckPalindrome("racecar");
            Assert.Equal(expected: true);
        }
    }
}
