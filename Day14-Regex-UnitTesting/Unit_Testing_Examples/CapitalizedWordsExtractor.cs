using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Unit_Testing_Examples
{
    public class CapitalizedWordsExtractor
    {
        public static List<string> GetCapitalizedWords(string text)
        {
            MatchCollection matches =
                Regex.Matches(text, @"\b[A-Z][a-z]*\b");


            List<string> words = new List<string>();


            foreach (Match match in matches)
            {
                words.Add(match.Value);
            }


            return words;
        }
    }
}