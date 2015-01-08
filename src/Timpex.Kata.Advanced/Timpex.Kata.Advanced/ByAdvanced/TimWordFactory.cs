using System;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByAdvanced
{
    public class TimWordFactory
    {
        public static Func<TimWordFactory> New = () => new TimWordFactory();

        public virtual TimWord Create()
        {
            return TimWord.New();
        }
    }
}