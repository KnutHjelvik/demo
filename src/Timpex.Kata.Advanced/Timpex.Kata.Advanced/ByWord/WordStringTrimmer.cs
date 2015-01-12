using System;

namespace Timpex.Kata.Advanced.ByWord
{
    public class WordStringTrimmer
    {
        public static Func<WordStringTrimmer> New = () => new WordStringTrimmer();

        public virtual string TrimString(string text)
        {
            return text.TrimEnd();
        }

        public WordStringTrimmer()
        {
        }
    }
}