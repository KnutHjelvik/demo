using System;

namespace Timpex.Sscc.ByCode
{
    public class ExtractApplicationIdentifier
    {
        private string _result;
        private Code _code;

        public static Func<ExtractApplicationIdentifier> New = () => new ExtractApplicationIdentifier();

        public string Extract(Code code)
        {
            _code = code;
            Execute();
            return _result;
        }

        private void Execute()
        {
            var code = _code.value;
            _result = code.Substring(0, 4);
        }

        public ExtractApplicationIdentifier()
        {
        }
    }
}