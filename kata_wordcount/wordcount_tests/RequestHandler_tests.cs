using System;
using NUnit.Framework;
using wordcount;

namespace wordcount_tests
{
    [TestFixture]
    public class RequestHandler_tests
    {
        [TestCase("Test Satz", 2)]
        [TestCase("123", 1)]
        [TestCase("123 Mary", 2)]
        [TestCase("1a2b3C", 1)]
        [TestCase("  a  b ", 2)]
        [TestCase("Mary had a little lamb", 5)]
        public void Akteptanztest(string text, int wordcount)
        {
            var sut = new Wordcounting();
            Assert.AreEqual(wordcount, sut.Count_words(text));
        }
    }
}