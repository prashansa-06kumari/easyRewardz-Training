using NUnit.Framework;
using Unit_Testing_Examples;

namespace NUnit_Test
{
    public class EmailExtractorTests
    {

        [Test]
        public void ValidEmail_ReturnsEmail()
        {
            string result = EmailExtractor.ExtractEmail(
                "My email is test@gmail.com"
            );

            Assert.That(result, Is.EqualTo("test@gmail.com"));
        }


        [Test]
        public void EmailWithDifferentDomain_ReturnsEmail()
        {
            string result = EmailExtractor.ExtractEmail(
                "Contact abc@yahoo.com"
            );

            Assert.That(result, Is.EqualTo("abc@yahoo.com"));
        }


        [Test]
        public void TextWithoutEmail_ReturnsEmpty()
        {
            string result = EmailExtractor.ExtractEmail(
                "Hello World"
            );

            Assert.That(result, Is.EqualTo(""));
        }


        [Test]
        public void MultipleEmails_ReturnsFirstEmail()
        {
            string result = EmailExtractor.ExtractEmail(
                "First a@gmail.com Second b@gmail.com"
            );

            Assert.That(result, Is.EqualTo("a@gmail.com"));
        }
    }
}