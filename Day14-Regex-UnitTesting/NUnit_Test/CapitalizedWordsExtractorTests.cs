using NUnit.Framework;
using Unit_Testing_Examples;
using System.Collections.Generic;

namespace NUnit_Test
{
    public class CapitalizedWordsExtractorTests
    {

        [Test]
        public void CapitalizedWords_ReturnsList()
        {
            List<string> result =
                CapitalizedWordsExtractor.GetCapitalizedWords(
                    "Hello my Name is John"
                );


            Assert.That(result.Count, Is.EqualTo(3));
            Assert.That(result, Contains.Item("Hello"));
            Assert.That(result, Contains.Item("Name"));
            Assert.That(result, Contains.Item("John"));
        }


        [Test]
        public void NoCapitalWords_ReturnsEmptyList()
        {
            List<string> result =
                CapitalizedWordsExtractor.GetCapitalizedWords(
                    "hello world"
                );


            Assert.That(result.Count, Is.EqualTo(0));
        }


        [Test]
        public void SingleCapitalWord_ReturnsOneWord()
        {
            List<string> result =
                CapitalizedWordsExtractor.GetCapitalizedWords(
                    "today I Code"
                );


            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result, Contains.Item("I"));
            Assert.That(result, Contains.Item("Code"));
        }
    }
}