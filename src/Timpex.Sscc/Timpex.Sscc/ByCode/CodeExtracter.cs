using System;

namespace Timpex.Sscc.ByCode
{
    public class CodeExtracter
    {

        private Code _innerCode;
        private string _result;

        public static Func<CodeExtracter> New = () => new CodeExtracter();

        public virtual void Setup(Code code)
        {
            _innerCode = code;
        }

        public virtual string ExtractSupplier()
        {
            ExtractSupplierCore();
            return _result;
        }

        public virtual string ExtractSerialNumber()
        {
            ExtractSerialNumberCore();
            return _result;
        }

        public virtual string ExtractIdentifier()
        {
            ExtractIdentifierCore();
            return _result;
        }

        public virtual string ExtractCountryCode()
        {
            ExtractCountryCodeCore();
            return _result;
        }

        private void ExtractIdentifierCore()
        {
            var code = _innerCode.value;
            _result = code.Substring(4, 1);
        }

        public virtual string ExtractApplicationIdentifier()
        {
            ExtractApplicationIdentifierCore();
            return _result;
        }

        private void ExtractSerialNumberCore()
        {
            var code = _innerCode.value;
            _result = code.Substring(11, 10);
        }

        private void ExtractSupplierCore()
        {
            var code = _innerCode.value;
            _result = code.Substring(8, 4);
        }

        private void ExtractApplicationIdentifierCore()
        {
            var code = _innerCode.value;
            _result = code.Substring(0, 4);
        }

        private void ExtractCountryCodeCore()
        {
            var code = _innerCode.value;
            _result = code.Substring(5, 2);
        }
    }
}