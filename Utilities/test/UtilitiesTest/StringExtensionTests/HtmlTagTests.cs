using NUnit.Framework;
using Utilities;

namespace UtilitiesTest.StringExtensionTests
{
    [TestFixture]
    public class HtmlTagTests
    {
        [Test]
        public void Test1()
        {
            var text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.<p>Integer nec odio.</p>Praesent libero. ";
            Assert.That(text.HasHtmlTag(), Is.True);
        }

        [Test]
        public void Test2()
        {
            var text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio.<br>Praesent libero. ";
            Assert.That(text.HasHtmlTag(), Is.True);
        }

        [Test]
        public void Test3()
        {
            var text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio. Praesent libero. ";
            Assert.That(text.HasHtmlTag(), Is.False);
        }
    }
}
