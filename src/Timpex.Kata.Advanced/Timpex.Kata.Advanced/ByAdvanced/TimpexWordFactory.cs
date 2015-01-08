using System;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByAdvanced
{
    public class TimpexWordFactory
    {
        public static Func<TimpexWordFactory> New = () => new TimpexWordFactory();
        
        public virtual TimpexWord Create()
        {
            return TimpexWord.New();
        }
    }
}