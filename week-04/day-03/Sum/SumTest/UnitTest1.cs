using NUnit.Framework;
using Sum;
using System.Collections.Generic;

namespace SumTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void SumTest()
        {
            var list = new List<int>() { 1, 2, 3 };
            int expected = 6;
            var program = new Program();
            int output = program.GetSum(list);
            Assert.AreEqual(expected, output);
            Assert.True(output == 6);
        }
    }
}
