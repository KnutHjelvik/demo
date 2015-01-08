using System;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByAdvanced
{
    public class PexWordFactory
    {

        public static Func<PexWordFactory> New = () => new PexWordFactory();

        public virtual PexWord Create()
        {
            return PexWord.New();
        }
    }
}