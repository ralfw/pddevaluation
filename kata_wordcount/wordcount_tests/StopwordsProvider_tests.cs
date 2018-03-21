using System;
using System.Diagnostics;
using NUnit.Framework;
using wordcount;

namespace wordcount_tests
{
    [TestFixture]
    public class StopwordsProvider_tests
    {
        [SetUp]
        public void Setup()
        {
            Environment.CurrentDirectory = TestContext.CurrentContext.TestDirectory;
        }
        
        [Test]
        public void Load_existing()
        {
            var sut = new StopwordsProvider("fewstopwords.txt");
            Assert.AreEqual(new[]{"a", "bb", "ccc"}, sut.Load());
        }
    }
}