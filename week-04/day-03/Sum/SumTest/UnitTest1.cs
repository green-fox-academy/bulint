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
            var list = new List<int> { 1, 2, 3 };
            int expected = 6;
            var program = new Program();
            int output = program.GetSum(list);
            Assert.AreEqual(expected, output);
        }
        [Test]
        public void TestEmptyList()
        {
            var list = new List<int>();
            var program = new Program();
            int output = program.GetSum(list);
            Assert.AreEqual(0, output);
        }
        [Test]
        public void TestOneElement()
        {
            var list = new List<int> { 1 };
            var program = new Program();
            int output = program.GetSum(list);
            Assert.AreEqual(1, output);
        }
        [Test]
        public void TestIfResult0()
        {
            var list = new List<int>();
            list = null;
            var program = new Program();
            bool output = program.GetNull(list);
            Assert.True(output);
        }
    }
}
