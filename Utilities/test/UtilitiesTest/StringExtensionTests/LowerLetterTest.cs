using NUnit.Framework;
using Utilities;

namespace UtilitiesTest.StringExtensionTests
{
    [TestFixture]
    public class LowerLetterTest
    {
        [Test]
        public void Test()
        {
            Assert.That("ASd".HasLowerLetter(), Is.True);
            Assert.That("asd".HasLowerLetter(), Is.True);
            Assert.That("ASD".HasLowerLetter(), Is.False);
        }
    }
}