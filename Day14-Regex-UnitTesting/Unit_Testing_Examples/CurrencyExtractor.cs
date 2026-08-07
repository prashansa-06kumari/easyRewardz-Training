using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Unit_Testing_Examples
{
    public class CurrencyExtractor
    {
        public static List<string> ExtractCurrency(string text)
        {
            string pattern = @"[$€₹]\d+";

            MatchCollection matches =
                Regex.Matches(text, pattern);


            List<string> currency =
                new List<string>();


            foreach (Match match in matches)
            {
                currency.Add(match.Value);
            }


            return currency;
        }
    }
}