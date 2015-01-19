using System;

namespace Timpex.Sscc.ByCode
{
    public class ExtractSerialNumber
    {
        private string _result;
        private Code _code;

        public static Func<ExtractSerialNumber> New = () => new ExtractSerialNumber();

        public string Extract(Code code)
        {
            _code = code;
            Execute();
            return _result;
        }

        private void Execute()
        {
            var code = _code.value;
            _result = code.Substring(11, 10);
        }

        public ExtractSerialNumber()
        {
        }
    }
}