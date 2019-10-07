using System;
using Xunit;
using Palindrone;

namespace GregPalindrone
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("nurses run")]
        [InlineData("racecaR")]
        [InlineData("1221")]
        [InlineData("never odd, or even")]
        public void isPalindroneReturnsTrueForPalindrone(string str)
        {
            //arrange
            var pal = new Palindrone.PalindroneClass(str);
            //act
            bool isPalindrone = pal.isPalindrone();
            //assert
            Assert.True(isPalindrone);
        }

        [Theory]
        [InlineData("one two one")]
        [InlineData("123abccba123")]
        public void isPalindroneReturnsFalseForNonPalindrone(string str)
        {
            //arrange
            var pal = new Palindrone.PalindroneClass(str);
            //act
            bool isPalindrone = pal.isPalindrone();
            //assert
            Assert.False(isPalindrone);
        }
    }
}
