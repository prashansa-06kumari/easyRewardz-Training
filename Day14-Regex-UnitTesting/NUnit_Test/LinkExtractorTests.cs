using NUnit.Framework;
using Unit_Testing_Examples;

namespace NUnit_Test
{
    public class LinkExtractorTests
    {

        [Test]
        public void ValidLink_ReturnsLink()
        {
            string result =
                LinkExtractor.ExtractLink(
                    "Visit https://google.com"
                );


            Assert.That(result, Is.EqualTo("https://google.com"));
        }


        [Test]
        public void HttpLink_ReturnsLink()
        {
            string result =
                LinkExtractor.ExtractLink(
                    "Website: http://example.com"
                );


            Assert.That(result, Is.EqualTo("http://example.com"));
        }


        [Test]
        public void TextWithoutLink_ReturnsEmpty()
        {
            string result =
                LinkExtractor.ExtractLink(
                    "No website available"
                );


            Assert.That(result, Is.EqualTo(""));
        }


        [Test]
        public void LinkWithPath_ReturnsCompleteLink()
        {
            string result =
                LinkExtractor.ExtractLink(
                    "Open https://example.com/about"
                );


            Assert.That(result,
                Is.EqualTo("https://example.com/about"));
        }
    }
}