using ClassLibrary2;
using System;
using Xunit;

namespace XUnitTestProject2
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("aaaaaaa")]
        public void Test1(string a)
        {
            Palindrome st = new Palindrome();


            Assert.True(st.GetStatus(a));

        }
        [Theory]
        [InlineData("nurses run")]
        public void Test2(string a)
        {
            Palindrome st = new Palindrome();

            Assert.True(st.GetStatus(a));

        }

        [Theory]
        [InlineData("nurses run")]
        public void Test3(string a)
        {
            Palindrome st = new Palindrome();
            Assert.Equal("nursesrun", st.rebuildingString(a));


        }
    }
}
