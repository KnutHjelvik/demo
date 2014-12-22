using System;
using Timpex.Kata.Advanced.ByCounter;

namespace Timpex.Kata.Advanced.ByConverter
{
    public class TextConverter:Converter<Counter>
    {
        public static Func<TextConverter> New = () => new TextConverter();

        public virtual string Convert(Counter counter)
        {
            return counter.Count.ToString();
        }
    }
}