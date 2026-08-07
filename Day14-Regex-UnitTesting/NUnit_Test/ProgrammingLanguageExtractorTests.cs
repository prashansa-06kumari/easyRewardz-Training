using NUnit.Framework;
using Unit_Testing_Examples;
using System.Collections.Generic;

namespace NUnit_Test
{
    public class ProgrammingLanguageExtractorTests
    {

        [Test]
        public void ExtractLanguages_ReturnsList()
        {
            List<string> result =
                ProgrammingLanguageExtractor.ExtractLanguages(
                    "I know C# and Python"
                );


            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result, Contains.Item("C#"));
            Assert.That(result, Contains.Item("Python"));
        }


        [Test]
        public void SingleLanguage_ReturnsOneItem()
        {
            List<string> result =
                ProgrammingLanguageExtractor.ExtractLanguages(
                    "Java is popular"
                );


            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result,
                Contains.Item("Java"));
        }


        [Test]
        public void NoLanguage_ReturnsEmptyList()
        {
            List<string> result =
                ProgrammingLanguageExtractor.ExtractLanguages(
                    "Hello World"
                );


            Assert.That(result.Count, Is.EqualTo(0));
        }


        [Test]
        public void MultipleLanguages_ReturnsAllLanguages()
        {
            List<string> result =
                ProgrammingLanguageExtractor.ExtractLanguages(
                    "C# Java JavaScript Ruby"
                );


            Assert.That(result.Count, Is.EqualTo(4));
        }
    }
}