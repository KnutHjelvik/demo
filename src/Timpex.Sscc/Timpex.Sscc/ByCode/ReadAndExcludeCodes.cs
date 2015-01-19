using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Timpex.Sscc.ByCode
{
    public class ReadAndExcludeCodes
    {
        private ReadCodesCore _innerCore = ReadCodesCore.New();
        private CodeExcluder _codeExcluder = CodeExcluder.New();
        private List<Code> _result = new List<Code>();
        private string _path;

        public static Func<ReadAndExcludeCodes> New = () => new ReadAndExcludeCodes();

        public ReadAndExcludeCodes(ReadCodesCore readCodesCore, CodeExcluder codeExcluder)
        {
            _innerCore = readCodesCore;
            _codeExcluder = codeExcluder;
        }

        public List<Code> Read(string path)
        {
            _path = path;
            ExecuteCore();
            return _result;
        }

        private void ExecuteCore()
        {
            var codes = _innerCore.ReadAll(_path);
            _result = _codeExcluder.Exclude(codes);
        }


        public ReadAndExcludeCodes()
        {
        }
    }
}