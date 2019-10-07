using System;
using Xunit;
using Assessment.Library;

namespace Assessment.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void IsPalindromeTrueInput()
        {
            //Arrange
            PalindromClass testString = new PalindromClass();


            //Act
            testString.MainString = "never odd, or even";

            //Assert
            Assert.Equal(expected: true, actual: testString.CheckPalindrom()); // This test will pass, since the input string is a Palindrome

        }
        [Fact]
        public void IsPalindromeFalseInput()
        {
            //Arrange
            PalindromClass testString = new PalindromClass();


            //Act
            testString.MainString = "ABXYS";

            //Assert
            Assert.Equal(expected: true, actual: testString.CheckPalindrom()); // This test shall fail, since we expect a Palindrome but the Input is not one

        }
    }
}
