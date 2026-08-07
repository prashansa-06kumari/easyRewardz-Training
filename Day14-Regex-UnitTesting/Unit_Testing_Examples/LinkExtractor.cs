using System.Text.RegularExpressions;

namespace Unit_Testing_Examples
{
    public class LinkExtractor
    {
        public static string ExtractLink(string text)
        {
            string pattern = @"https?://[^\s]+";

            Match match = Regex.Match(text, pattern);

            return match.Value;
        }
    }
}