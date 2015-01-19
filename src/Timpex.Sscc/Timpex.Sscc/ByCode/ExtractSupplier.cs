using System;

namespace Timpex.Sscc.ByCode
{
    public class ExtractSupplier
    {
        private string _result;
        private Code _code;

        public static Func<ExtractSupplier> New = () => new ExtractSupplier();

        public string Extract(Code code)
        {
            _code = code;
            Execute();
            return _result;
        }

        private void Execute()
        {
            var code = _code.value;
            _result = code.Substring(7, 4);
        }

        public ExtractSupplier()
        {
        }
    }
}