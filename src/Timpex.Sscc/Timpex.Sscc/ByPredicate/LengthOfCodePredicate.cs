using System;
using Timpex.Sscc.ByCode;

namespace Timpex.Sscc.ByPredicate
{
    public class LengthOfCodePredicate
    {
        public static Func<LengthOfCodePredicate> New = () => new LengthOfCodePredicate();


        public virtual bool Matches(Code code)
        {
            return CoreMatch(code);
        }

        private bool CoreMatch(Code code)
        {
            return code.value.Length == 22;
        }

        public LengthOfCodePredicate()
        {
        }
    }
}