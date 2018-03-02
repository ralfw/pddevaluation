using System;
using galgenmännchen;
using NUnit.Framework;

namespace galgenmännchen_tests
{
    [TestFixture]
    public class Galgenmännchen_test
    {
        [Test]
        public void Wort_mit_1_Buchstabe_der_passt()
        {
            var sut = new Galgenmännchen("a");
            
            var result = sut.RateBuchstabe('a');
            Assert.AreEqual("a", result);
        }
        
        [Test]
        public void Wort_mit_1_Buchstabe_der_nicht_passt()
        {
            var sut = new Galgenmännchen("a");
            
            var result = sut.RateBuchstabe('x');
            Assert.AreEqual("-", result);
        }
        
        [Test]
        public void Wort_mit_1_Buchstabe_der_passt_und_caseinsensitive()
        {
            var sut = new Galgenmännchen("a");
            
            var result = sut.RateBuchstabe('A');
            Assert.AreEqual("a", result);
        }
        
        
        
        // @todo #1: Tests für Worte mit mehreren Buchstaben
        [Test]
        public void Wort_mit_mehreren_verschiedenen_Buchstaben()
        {
            var sut = new Galgenmännchen("abc");
            
            var result = sut.RateBuchstabe('A');
            Assert.AreEqual("a--", result);
            result = sut.RateBuchstabe('c');
            Assert.AreEqual("a-c", result);
            result = sut.RateBuchstabe('b');
            Assert.AreEqual("abc", result);
        }
        
        // @todo #1: Tests für Worte mit wiederholten Buchstaben
    }
}