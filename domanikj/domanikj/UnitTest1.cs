using System;
using Xunit;
using domanikj.Lib;

namespace domanikj
{
    public class UnitTest1
    {

        [Fact]
        public void TestPal()
        {
            Class1 PalChecker = new Class1();
            
            var test1 = PalChecker.IsPalindrome("dskfdskfa");
            Assert.False(test1);
            
        }

        [Fact]
        public void testPalPass()
        {
            Class1 PalChecker = new Class1();

            var test2 = PalChecker.IsPalindrome("mom");
            Assert.True(test2);

        }
    }
}
