using System;
using System.Collections.Generic;
using Timpex.Sscc.ByPredicate;

namespace Timpex.Sscc.ByCode
{
    public class CodelistFactory
    {
        private EmptyPredicate _emptyPredicate = EmptyPredicate.New();
        private List<Code> _codeList = new List<Code>();
        private CodeFactory _codeFactory = CodeFactory.New();

        public static Func<CodelistFactory> New = () => new CodelistFactory();

        public CodelistFactory(EmptyPredicate emptyPredicate, CodeFactory codeFactory)
        {
            _emptyPredicate = emptyPredicate;
            _codeFactory = codeFactory;
        }

        public virtual List<Code> SanitizeCodeList(List<string> codes)
        {
            foreach (var code in codes)
            {
                if (!_emptyPredicate.IsEmpty(code))
                    _codeList.Add(_codeFactory.CreateCode(code));
            }
            return _codeList;
        }

        public CodelistFactory()
        {
        }
    }
}