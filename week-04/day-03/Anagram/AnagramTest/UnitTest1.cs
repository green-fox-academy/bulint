using NUnit.Framework;
using Anagram;

namespace AnagramTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void AnagramTest()
        {
            var program = new Program();
            bool output = program.AnagramOrNot("dog", "god");
            Assert.True(output == true);
        }
    }
}
