using System;

namespace Timpex.Sscc.ByPredicate
{
    public class EmptyPredicate
    {
        public static Func<EmptyPredicate> New = () => new EmptyPredicate();
   
        public virtual bool IsEmpty(string line)
        {
            return line == String.Empty;
        }

        public EmptyPredicate()
        {
        }
    }
}