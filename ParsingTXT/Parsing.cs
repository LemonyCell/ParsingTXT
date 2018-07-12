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

        public List<Sentence> ParseSentences(string searchedWord)
        {
            var text = ParseText(searchedWord);
            var sentences = new List<Sentence>();
            Sentence s;
            foreach (var sentence in text)
            {
                s.Text = sentence;
                s.NumberOfMatches = CountWords(sentence, searchedWord);
                sentences.Add(s);
            }

            return sentences;
        }

        private int CountWords(string sentence, string word)
        {
            int count = (sentence.Length - sentence.Replace(word, "").Length) / word.Length;
            return count;
        }

        public string TurnTheSentence(string sentence)
        {
            var words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (var i=0; i< words.Length; i++)
            {
                words[i] = ReverseString(words[i]);
            }
            var result = String.Join(" ", words);
            return result;
        }

        public string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

    }
}
