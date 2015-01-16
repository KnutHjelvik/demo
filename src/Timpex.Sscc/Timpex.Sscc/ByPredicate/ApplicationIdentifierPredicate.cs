using System;
using Timpex.Sscc.ByCode;

namespace Timpex.Sscc.ByPredicate
{
    public class ApplicationIdentifierPredicate
    {
        public static Func<ApplicationIdentifierPredicate> New = () => new ApplicationIdentifierPredicate();

        public virtual bool Matches(Code code)
        {
            return MatchesCore(code);
        }

        private bool MatchesCore(Code code)
        {
            return code.value.IndexOf("(") == 0 && code.value.IndexOf(")") ==3;
        }
    }
}