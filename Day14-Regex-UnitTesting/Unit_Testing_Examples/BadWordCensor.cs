using System.Text.RegularExpressions;

namespace Unit_Testing_Examples
{
    public class BadWordCensor
    {
        public static string CensorWord(string text, string badWord)
        {
            string pattern = @"\b" + badWord + @"\b";

            return Regex.Replace(
                text,
                pattern,
                "***",
                RegexOptions.IgnoreCase
            );
        }
    }
}