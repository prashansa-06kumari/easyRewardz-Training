using NUnit.Framework;
using Unit_Testing_Examples;
using System.Collections.Generic;

namespace NUnit_Test
{
    public class CurrencyExtractorTests
    {

        [Test]
        public void ExtractDollar_ReturnsCurrency()
        {
            List<string> result =
                CurrencyExtractor.ExtractCurrency(
                    "Price is $100"
                );


            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result,
                Contains.Item("$100"));
        }


        [Test]
        public void ExtractMultipleCurrency_ReturnsAll()
        {
            List<string> result =
                CurrencyExtractor.ExtractCurrency(
                    "Items cost $100 and ₹500"
                );


            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result,
                Contains.Item("$100"));
            Assert.That(result,
                Contains.Item("₹500"));
        }


        [Test]
        public void NoCurrency_ReturnsEmptyList()
        {
            List<string> result =
                CurrencyExtractor.ExtractCurrency(
                    "No price available"
                );


            Assert.That(result.Count, Is.EqualTo(0));
        }


        [Test]
        public void EuroCurrency_ReturnsValue()
        {
            List<string> result =
                CurrencyExtractor.ExtractCurrency(
                    "Cost is €50"
                );


            Assert.That(result,
                Contains.Item("€50"));
        }
    }
}