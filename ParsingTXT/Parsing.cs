using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ParsingTXT
{
    public class Parsing
    {
        private string _text;

        public void SetText(string text)
        {
            _text = text;
        }

        public List<string> ParseText(string searchedWord)
        {
            var sentences = new List<string>();
            string text = _text.Replace(".", "..");
            var pattern = @"/((\.)[\n 0-9A-Za-z-]+( " + searchedWord + @" )[\n 0-9A-Za-z-]+(\.))|((\." + searchedWord + @" )|(\. " + searchedWord + @" )[\n 0-9A-Za-z-]+(\\.))|((\\.)[\n 0-9A-Za-z-]+( " + searchedWord + @"\\.))/";
            Regex regex = new Regex(pattern);
                //@"((\.)[\n0-9A-Za-z-]+({Regex.Escape(searchedWord)})[\n0-9A-Za-z-]+(\.))|((\.{Regex.Escape(searchedWord)} )|(\. {Regex.Escape(searchedWord)} )[\n 0-9A-Za-z-]+(\.))|((\.)[\n 0-9A-Za-z-]+({Regex.Escape(searchedWord)}\.))"
            
            MatchCollection matches = regex.Matches(text);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    //Console.WriteLine(match.Value);
                    sentences.Add(match.Value);
                }
            }
            else
            {
                Console.WriteLine("match not found");
            }
            return sentences;
        }
    }
}
