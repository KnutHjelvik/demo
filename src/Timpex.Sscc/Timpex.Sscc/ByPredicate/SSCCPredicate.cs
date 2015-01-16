using System;
using Timpex.Sscc.ByCode;

namespace Timpex.Sscc.ByPredicate
{
    public class SSCCPredicate
    {
        private ApplicationIdentifierPredicate _applicationIdentifierPredicate = ApplicationIdentifierPredicate.New();
        private LengthOfCodePredicate _lengthOfCodePredicate = LengthOfCodePredicate.New();

        public static Func<SSCCPredicate> New = () => new SSCCPredicate();

        public SSCCPredicate(ApplicationIdentifierPredicate applicationIdentifierPredicate, LengthOfCodePredicate lengthOfCodePredicate)
        {
            _applicationIdentifierPredicate = applicationIdentifierPredicate;
            _lengthOfCodePredicate = lengthOfCodePredicate;
        }

        public virtual bool Matches(Code code)
        {
            return CoreMatch(code);
        }

        private bool CoreMatch(Code code)
        {
            return _lengthOfCodePredicate.Matches(code) && _applicationIdentifierPredicate.Matches(code);
        }

        public SSCCPredicate()
        {
        }
    }
}