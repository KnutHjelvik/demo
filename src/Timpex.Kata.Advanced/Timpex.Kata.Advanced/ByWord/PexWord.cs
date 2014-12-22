using System;

namespace Timpex.Kata.Advanced.ByWord
{
    public class PexWord:Word
    {
        public static Func<PexWord> New = () => new PexWord();
        public virtual string Value()
        {
            return "pex";
        }
    }
}