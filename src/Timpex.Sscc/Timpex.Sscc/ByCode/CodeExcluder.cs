using System;
using System.Collections.Generic;
using NUnit.Framework;
using Timpex.Sscc.ByPredicate;

namespace Timpex.Sscc.ByCode
{
    public class CodeExcluder
    {
        private SSCCPredicate _ssccPredicate = SSCCPredicate.New();
        private List<Code> _result = new List<Code>();

        public static Func<CodeExcluder> New = () => new CodeExcluder();

        public CodeExcluder(SSCCPredicate ssccPredicate)
        {
            _ssccPredicate = ssccPredicate;
        }

        public virtual List<Code> Exclude(List<Code> codeList)
        {
            foreach (Code code in codeList)
            {
                if(_ssccPredicate.Matches(code))
                    _result.Add(code);
            }
            return _result;
        }

        public CodeExcluder()
        {
        }
    }
}