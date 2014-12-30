using System;

namespace Timpex.Kata.Advanced.ByFactory
{
    public class Factory<TType> where TType:new()
    {
        public static Func<Factory<TType>> New = () => new Factory<TType>();


        public virtual TType Create()
        {
            return new TType();
        }
    }
}