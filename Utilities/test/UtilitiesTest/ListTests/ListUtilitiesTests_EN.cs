using NUnit.Framework;
using System.Collections.Generic;
using System.Globalization;
using Utilities;

namespace UtilitiesTest
{
    [TestFixture]
    public class ListUtilitiesTests_EN
    {
        [OneTimeSetUp]
        public void Setup()
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        }

        [Test]
        public void ListTest1()
        {
            var listA = new List<string> { "0", "1", "2", "3" };
            Assert.That(ListUtilities.IsInAlphabeticalOrder(listA), Is.True);
        }

        [Test]
        public void ListTest2()
        {
            var listA = new List<string> { "a0", "a1", "a2", "a3" };
            Assert.That(ListUtilities.IsInAlphabeticalOrder(listA), Is.True);
        }

        [Test]
        public void ListTest3()
        {
            var listA = new List<string> { "a0", "a0", "a0", "a0" };
            Assert.That(ListUtilities.IsInAlphabeticalOrder(listA), Is.True);
        }

        [Test]
        public void ListTest4()
        {
            var listA = new List<string> { "r", "s", "t", "g" };
            Assert.That(ListUtilities.IsInAlphabeticalOrder(listA), Is.False);
        }
    }
}