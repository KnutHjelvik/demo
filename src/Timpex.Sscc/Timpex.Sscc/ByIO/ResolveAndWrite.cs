using System;
using System.Collections.Generic;
using Timpex.Sscc.ByDto;

namespace Timpex.Sscc.ByIO
{
    public class ResolveAndWrite
    {
        private CodeDtoArrayCreater _codeDtoArrayCreater = CodeDtoArrayCreater.New();
        private CodeWriterCore _innerWriter = CodeWriterCore.New();

        public static Func<ResolveAndWrite> New = () => new ResolveAndWrite();

        public ResolveAndWrite(CodeDtoArrayCreater codeDtoArrayCreater, CodeWriterCore codeWriterCore)
        {
            _innerWriter = codeWriterCore;
            _codeDtoArrayCreater = codeDtoArrayCreater;
        }

        public virtual void Execute(List<CodeDto> dtos)
        {
            var codes = _codeDtoArrayCreater.Create(dtos);
            _innerWriter.WriteCodes(codes);
        }

        public ResolveAndWrite()
        {
        }
    }
}