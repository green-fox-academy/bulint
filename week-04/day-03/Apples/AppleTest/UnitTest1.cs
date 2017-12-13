using NUnit.Framework;
using Apples;

namespace ApplesTest
{
    [TestFixture]
    public class MyFirstTest
    {
        [Test]
        public void TestProgram()
        {
            string expected = "apple";
            var apple = new Apple();
            string output = apple.GetApple();
            Assert.AreEqual(expected, output);
        }
    }
}