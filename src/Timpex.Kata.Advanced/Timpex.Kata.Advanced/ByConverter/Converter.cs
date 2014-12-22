namespace Timpex.Kata.Advanced.ByConverter
{
    public interface Converter<TType>
    {
        string Convert(TType type);
    }
}