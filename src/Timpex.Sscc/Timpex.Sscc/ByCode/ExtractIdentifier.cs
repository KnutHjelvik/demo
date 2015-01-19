using System;

namespace Timpex.Sscc.ByCode
{
    public class ExtractIdentifier
    {
        private string _result;
        private Code _code;

        public static Func<ExtractIdentifier> New = () => new ExtractIdentifier();

        public string Extract(Code code)
        {
            _code = code;
            Execute();
            return _result;
        }

        private void Execute()
        {
            var code = _code.value;
            _result = code.Substring(4, 1);
        }

        public ExtractIdentifier()
        {
        }
    }
}