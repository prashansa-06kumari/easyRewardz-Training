using System.Text.RegularExpressions;

namespace Unit_Testing_Examples
{
    public class EmailExtractor
    {
        public static string ExtractEmail(string text)
        {
            string pattern = @"[\w\.-]+@[\w\.-]+\.\w+";

            Match match = Regex.Match(text, pattern);

            return match.Value;
        }
    }
}