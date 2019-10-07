using System;
using Assessment.Library;
using Xunit;

namespace AssessmentTesting
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("abc")]
        [InlineData("racecaR")]
        public void IsPalidrome(string input)
        {

            //Arrange
            PalindromeString testingString = new PalindromeString();

            //Act
            bool result = testingString.IsPalindromeString(input);
            if (result)
            {
                Console.WriteLine("it's true");
            }
            else
            {
                Console.WriteLine("it's false");
            }

            //
            Assert.Equal(expected: "it 's false", actual: "it's true");
        }
    }
}
