using System;

namespace Timpex.Sscc
{
    public class Base_Act
    {
        protected virtual void Arrange()
        {
        }

        protected virtual void Act()
        {
        }

        protected void StubNew<TType>(ref Func<TType> original, TType instance)
        {
            new NewStubber<TType>(ref original, instance);
        }

        protected void StubManyNew<TType>(ref Func<TType> original, params TType[] instances)
        {
            new NewStubber<TType>(ref original, instances);
        }
    }
}
