using NUnit.Framework;
using Unit_Testing_Examples;

namespace NUnit_Test
{
    public class SpaceReplacerTests
    {

        [Test]
        public void ReplaceSingleSpace_ReturnsUnderscore()
        {
            string result =
                SpaceReplacer.ReplaceSpaces("Hello World");


            Assert.That(result, Is.EqualTo("Hello_World"));
        }


        [Test]
        public void ReplaceMultipleSpaces_ReturnsSingleUnderscore()
        {
            string result =
                SpaceReplacer.ReplaceSpaces("Hello    World");


            Assert.That(result, Is.EqualTo("Hello_World"));
        }


        [Test]
        public void StringWithoutSpace_ReturnsSameString()
        {
            string result =
                SpaceReplacer.ReplaceSpaces("Hello");


            Assert.That(result, Is.EqualTo("Hello"));
        }


        [Test]
        public void ReplaceSpacesInSentence_ReturnsCorrectString()
        {
            string result =
                SpaceReplacer.ReplaceSpaces(
                    "C sharp is easy"
                );


            Assert.That(result,
                Is.EqualTo("C_sharp_is_easy"));
        }
    }
}