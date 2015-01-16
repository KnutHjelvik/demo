namespace Timpex.Core
{
    public interface ISetup<TType,TArg>
    {
        TArg Setup(TArg argument);
    }
}
