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
            var text = _text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            var sentences = new List<string>();
            foreach (var sentence in text)
            {
                var b = (sentence.Contains(" " + searchedWord + " ")) | (sentence.Contains(searchedWord + " ")) || (sentence.Contains(searchedWord + " "));
                if (b)
                {
                    sentences.Add(sentence);
                }
            }

            return sentences;
        }
    }
}
