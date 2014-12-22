using System;

namespace Timpex.Kata.Advanced.ByWord
{
    public class TimpexWord:Word
    {
        public static Func<TimpexWord> New = () => new TimpexWord();

        public virtual string Value()
        {
            return "timpex";
        }
    }
}