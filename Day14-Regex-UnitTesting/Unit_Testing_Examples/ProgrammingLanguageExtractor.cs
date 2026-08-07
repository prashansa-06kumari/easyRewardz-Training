using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Unit_Testing_Examples
{
    public class ProgrammingLanguageExtractor
    {
        public static List<string> ExtractLanguages(string text)
        {
            string pattern = 
                @"\b(C#|Java|Python|JavaScript|C\+\+|Ruby)\b";


            MatchCollection matches =
                Regex.Matches(text, pattern);


            List<string> languages = new List<string>();


            foreach (Match match in matches)
            {
                languages.Add(match.Value);
            }


            return languages;
        }
    }
}