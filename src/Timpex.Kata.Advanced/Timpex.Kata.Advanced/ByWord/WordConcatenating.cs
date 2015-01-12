using System;
using System.Linq;

namespace Timpex.Kata.Advanced.ByWord
{
    public class WordConcatenating
    {
        public static Func<WordConcatenating> New = () => new WordConcatenating();
        private WordStringTrimmer _wordStringTrimmer = WordStringTrimmer.New();

        private string _space = " ";

        public WordConcatenating(WordStringTrimmer wordStringTrimmer)
        {
            _wordStringTrimmer = wordStringTrimmer;
        }

        public virtual string Concatinate(params Word[] words)
        {
            var mergedString = words.Aggregate(String.Empty, (current, word) => current + word.Value() + _space);
            return mergedString.TrimEnd();
        }

        public WordConcatenating()
        {
        }
    }
}