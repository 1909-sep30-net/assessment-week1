using System;
using Xunit;
using IsPolindomeApp.Library;

namespace IsPolindrome.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var word1 = new Polindome("nurses run");
            var word2 = new Polindome("racecaR");
            var word3 = new Polindome("1221");
            var word4 = new Polindome("one two one");
            var word5 = new Polindome("never odd, or even.");

            word1.Replace();
            word2.Replace();
            word3.Replace();
            word4.Replace();
            word5.Replace();

            Assert.Equal(expected: "nursesrun", actual: word1.ToString());
            Assert.Equal(expected: "racecaR", actual: word2.ToString());
            Assert.Equal(expected: "1221", actual: word3.ToString());
            Assert.Equal(expected: "onetwoone", actual: word4.ToString());
            Assert.Equal(expected: "neveroddoreven", actual: word5.ToString());
        }
    }
}
