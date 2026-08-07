using NUnit.Framework;
using Unit_Testing_Examples;

namespace NUnit_Test
{
    public class BadWordCensorTests
    {

        [Test]
        public void BadWord_IsReplaced()
        {
            string result =
                BadWordCensor.CensorWord(
                    "This is bad",
                    "bad"
                );


            Assert.That(result,
                Is.EqualTo("This is ***"));
        }


        [Test]
        public void MultipleBadWords_AreReplaced()
        {
            string result =
                BadWordCensor.CensorWord(
                    "bad BAD Bad",
                    "bad"
                );


            Assert.That(result,
                Is.EqualTo("*** *** ***"));
        }


        [Test]
        public void TextWithoutBadWord_ReturnsSameText()
        {
            string result =
                BadWordCensor.CensorWord(
                    "Hello World",
                    "bad"
                );


            Assert.That(result,
                Is.EqualTo("Hello World"));
        }


        [Test]
        public void DifferentCaseWord_IsCensored()
        {
            string result =
                BadWordCensor.CensorWord(
                    "This is BAD",
                    "bad"
                );


            Assert.That(result,
                Is.EqualTo("This is ***"));
        }
    }
}