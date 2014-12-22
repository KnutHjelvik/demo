using System;

namespace Timpex.Kata.Advanced.ByWord
{
    public class TimWord:Word
    {

        public static Func<TimWord> New = () => new TimWord();

        public virtual string Value()
        {
            return "tim";
        }
    }
}