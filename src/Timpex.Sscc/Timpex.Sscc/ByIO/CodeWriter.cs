using System;
using System.Collections.Generic;
using Timpex.Sscc.ByDto;

namespace Timpex.Sscc.ByIO
{
    public class CodeWriter
    {
        private CodeDtoArrayCreater _codeDtoArrayCreater = CodeDtoArrayCreater.New();
        private CodeWriterCore _innerWriter = CodeWriterCore.New();

        public static Func<CodeWriter> New = () => new CodeWriter();

        public CodeWriter(CodeDtoArrayCreater codeDtoArrayCreater, CodeWriterCore codeWriterCore)
        {
            _innerWriter = codeWriterCore;
            _codeDtoArrayCreater = codeDtoArrayCreater;
        }

        public virtual void Write(List<CodeDto> dtos)
        {
            var codes = _codeDtoArrayCreater.Create(dtos);
            _innerWriter.WriteCodes(codes);
        }

        public CodeWriter()
        {
        }
    }
}