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
            bool isGumTrue = Palindrome.IsPalindrome("A tin mug for a jar of gum Nita");
            bool isNursesTrue = Palindrome.IsPalindrome("nurses run");
            bool isRacecarCapitalizedTrue = Palindrome.IsPalindrome("racecaR");
            bool isNumbersTrue = Palindrome.IsPalindrome("1221");

            Assert.True(isRacecarTrue);
            Assert.False(isIcecreamTrue);
            Assert.False(isStadiumTrue);
            Assert.False(isKeyboardTrue);
            Assert.True(isRacecarWithSpaceTrue);
            Assert.True(isGumTrue);
            Assert.True(isNursesTrue);
            Assert.True(isRacecarCapitalizedTrue);
            Assert.True(isNumbersTrue);
        }
    }
}
