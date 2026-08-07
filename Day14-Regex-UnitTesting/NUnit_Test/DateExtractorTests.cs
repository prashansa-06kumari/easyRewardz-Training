using NUnit.Framework;
using Unit_Testing_Examples;

namespace NUnit_Test
{
    public class DateExtractorTests
    {

        [Test]
        public void ValidDate_ReturnsDate()
        {
            string result =
                DateExtractor.ExtractDate(
                    "My birthday is 10/08/2004"
                );


            Assert.That(result, Is.EqualTo("10/08/2004"));
        }


        [Test]
        public void TextWithoutDate_ReturnsEmpty()
        {
            string result =
                DateExtractor.ExtractDate(
                    "No date available"
                );


            Assert.That(result, Is.EqualTo(""));
        }


        [Test]
        public void DifferentDate_ReturnsCorrectDate()
        {
            string result =
                DateExtractor.ExtractDate(
                    "Meeting date is 25/12/2026"
                );


            Assert.That(result, Is.EqualTo("25/12/2026"));
        }


        [Test]
        public void InvalidFormat_ReturnsEmpty()
        {
            string result =
                DateExtractor.ExtractDate(
                    "Date is 2026-12-25"
                );


            Assert.That(result, Is.EqualTo(""));
        }
    }
}