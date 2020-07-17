using NUnit.Framework;
using Utilities;

namespace UtilitiesTest.StringExtensionTests
{
    [TestFixture]
    public class CrsKeyTests
    {
        [Test]
        public void Test0()
        {
            var text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Wow.";
            Assert.That(text.IsCrsKeyLike(), Is.False);
        }

        [Test]
        public void Test1()
        {
            var text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
            Assert.That(text.IsCrsKeyLike(), Is.False);
        }

        [Test]
        public void Test2()
        {
            var text = "Lorem ipsum dolor.sit amet, consectetur adipiscing elit.";
            Assert.That(text.IsCrsKeyLike(), Is.True);
        }

        [Test]
        public void Test3()
        {
            var text = "Lorem ipsum dolor.sit.amet, consectetur adipiscing elit.";
            Assert.That(text.IsCrsKeyLike(), Is.True);
        }
    }
}
