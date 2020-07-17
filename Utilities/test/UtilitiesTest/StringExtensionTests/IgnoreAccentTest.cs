using NUnit.Framework;
using System.Globalization;
using Utilities;

namespace UtilitiesTest.StringExtensionTests
{
    [TestFixture]
    public class IgnoreAccentTest
    {
        [Test]
        public void Test()
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("hu-HU");

            Assert.That("a".ContainsIgnoreCase("a"), Is.True);
            Assert.That("a".ContainsIgnoreCase("á"), Is.True);
            Assert.That("a".ContainsIgnoreCase("A"), Is.True);
            Assert.That("a".ContainsIgnoreCase("Á"), Is.True);

            Assert.That("á".ContainsIgnoreCase("a"), Is.True);
            Assert.That("á".ContainsIgnoreCase("á"), Is.True);
            Assert.That("á".ContainsIgnoreCase("A"), Is.True);
            Assert.That("á".ContainsIgnoreCase("Á"), Is.True);
        }

        [Test]
        public void Test2()
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("hu-HU");

            Assert.That("álom".ContainsIgnoreCase("alom"), Is.True);
            Assert.That("alom".ContainsIgnoreCase("álom"), Is.True);
        }

        [Test]
        public void Test3()
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

            Assert.That("SAVAGE".ContainsIgnoreCase("savage"), Is.True);
            Assert.That("savage".ContainsIgnoreCase("SAVAGE"), Is.True);
        }
    }
}