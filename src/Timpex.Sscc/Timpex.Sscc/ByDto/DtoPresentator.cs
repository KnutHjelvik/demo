using System;
using System.Collections.Generic;
using Timpex.Sscc.ByCode;

namespace Timpex.Sscc.ByDto
{
    public class DtoPresentator
    {
        private CodeDtoFactory _codeDtoFactory = CodeDtoFactory.New();
        private List<CodeDto> _result = new List<CodeDto>();

        public static Func<DtoPresentator> New = () => new DtoPresentator();

        public DtoPresentator(CodeDtoFactory codeDtoFactory)
        {
            _codeDtoFactory = codeDtoFactory;
        }

        public virtual List<CodeDto> Present(List<Code> codes)
        {
            foreach (var code in codes)
            {
                var innerCode = _codeDtoFactory.Create(code);
                _result.Add(innerCode);
            }
            return _result;
        }


        public DtoPresentator()
        {
        }
    }
}