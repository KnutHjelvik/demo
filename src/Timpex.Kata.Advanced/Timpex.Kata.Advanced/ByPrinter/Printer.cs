using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByPrinter
{
    public interface Printer<TWord> where TWord:Word
    {
        string Print(TWord word);
    }
}