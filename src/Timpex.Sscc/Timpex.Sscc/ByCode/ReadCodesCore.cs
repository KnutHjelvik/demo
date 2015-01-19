using System;
using System.Collections.Generic;
using System.Linq;
using Timpex.IO.ByReading;

namespace Timpex.Sscc.ByCode
{
    public class ReadCodesCore
    {
        private FileReader _fileReader = FileReader.New();
        private CodelistFactory _codelistFactory = CodelistFactory.New();

        public static Func<ReadCodesCore> New = () => new ReadCodesCore();

        public ReadCodesCore(FileReader fileReader, CodelistFactory codelistFactory)
        {
            _fileReader = fileReader;
            _codelistFactory = codelistFactory;
        }

        public virtual List<Code> ReadAll(string path)
        {
            var codes = _fileReader.ReadAllLines(path).ToList();
            return _codelistFactory.SanitizeCodeList(codes);
        }

        public ReadCodesCore()
        {
        }
    }
}