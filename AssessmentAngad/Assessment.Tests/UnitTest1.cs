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
            testString.MainString = "123abccba123";

            //Assert
            Assert.Equal(expected: false, actual: testString.CheckPalindrom()); // Change the Expected Parameter to true to see the test fail

        }
    }
}
