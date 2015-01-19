using System;

namespace Timpex.Sscc.ByCode
{
    public class ExtractCountryCode
    {
            private string _result;
        private Code _code;

        public static Func<ExtractCountryCode> New = () => new ExtractCountryCode();

        public string Extract(Code code)
        {
            _code = code;
            Execute();
            return _result;
        }

        private void Execute()
        {
            var code = _code.value;
            _result = code.Substring(5, 2);
        }

        public ExtractCountryCode()
        {
        }
    }
}