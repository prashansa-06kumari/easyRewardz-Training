using System.Text.RegularExpressions;

namespace Unit_Testing_Examples
{
    public class DateExtractor
    {
        public static string ExtractDate(string text)
        {
            string pattern = @"\b\d{2}/\d{2}/\d{4}\b";

            Match match = Regex.Match(text, pattern);

            return match.Value;
        }
    }
}