using System;
using NUnit.Framework;
using wordcount;

namespace wordcount_tests
{
    [TestFixture]
    public class RequestHandler_tests
    {
        [SetUp]
        public void Setup() {
            Environment.CurrentDirectory = TestContext.CurrentContext.TestDirectory;
        }
        
        
        [TestCase("Test Satz", 2)]
        [TestCase("123", 1)]
        [TestCase("123 Mary", 2)]
        [TestCase("1a2b3C", 1)]
        [TestCase("  a  b ", 2)]
        [TestCase("Mary had a little lamb", 5)]
        public void Akteptanztest_ohne_Stoppworte(string text, int wordcount)
        {
            var swp = new StopwordsProvider("nostopwords.txt");
            var sut = new RequestHandler(swp);
            Assert.AreEqual(wordcount, sut.Count_words(text));
        }
        
        
        [TestCase("Mary had a little lamb", 3)]
        public void Akteptanztest_mit_Stoppworten(string text, int wordcount)
        {
            var swp = new StopwordsProvider("somestopwords.txt");
            var sut = new RequestHandler(swp);
            Assert.AreEqual(wordcount, sut.Count_words(text));
        }
    }
}