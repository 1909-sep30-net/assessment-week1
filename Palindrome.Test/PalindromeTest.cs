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
            bool isStadiumTrue = Palindrome.IsPalindrome("stadium");
            bool isKeyboardTrue = Palindrome.IsPalindrome("keyboard");
            bool isRacecarWithSpaceTrue = Palindrome.IsPalindrome("race car");

            Assert.True(isRacecarTrue);
            Assert.False(isIcecreamTrue);
            Assert.False(isStadiumTrue);
            Assert.False(isKeyboardTrue);
            Assert.True(isRacecarWithSpaceTrue);
        }
    }
}
