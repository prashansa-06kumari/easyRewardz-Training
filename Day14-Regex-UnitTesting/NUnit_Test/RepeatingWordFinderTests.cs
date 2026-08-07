using NUnit.Framework;
using Unit_Testing_Examples;
using System.Collections.Generic;

namespace NUnit_Test
{
    public class RepeatingWordFinderTests
    {

        [Test]
        public void RepeatedWord_ReturnsWord()
        {
            List<string> result =
                RepeatingWordFinder.FindRepeatedWords(
                    "hello world hello"
                );


            Assert.That(result,
                Contains.Item("hello"));
        }


        [Test]
        public void MultipleRepeatedWords_ReturnsAll()
        {
            List<string> result =
                RepeatingWordFinder.FindRepeatedWords(
                    "cat dog cat dog"
                );


            Assert.That(result.Count,
                Is.EqualTo(2));

            Assert.That(result,
                Contains.Item("cat"));

            Assert.That(result,
                Contains.Item("dog"));
        }


        [Test]
        public void NoRepeatedWords_ReturnsEmptyList()
        {
            List<string> result =
                RepeatingWordFinder.FindRepeatedWords(
                    "hello world"
                );


            Assert.That(result.Count,
                Is.EqualTo(0));
        }


        [Test]
        public void UpperCaseWord_IsDetected()
        {
            List<string> result =
                RepeatingWordFinder.FindRepeatedWords(
                    "Hello hello"
                );


            Assert.That(result,
                Contains.Item("hello"));
        }
    }
}