using System;
using Timpex.Sscc.ByCode;

namespace Timpex.Sscc.ByDto
{
    public class CodeToDtoMapper
    {
        private CodeExtracter _extracter = CodeExtracter.New();
        private CodeDto _result;
        private Code _code;

        public static Func<CodeToDtoMapper> New = () => new CodeToDtoMapper();


        public CodeToDtoMapper(CodeExtracter extracter)
        {
            _extracter = extracter;
        }

        public virtual CodeDto Map(Code code)
        {
            _code = code;
            MapCore();
            return _result;
        }

        private void MapCore()
        {
            _extracter.Setup(_code);
            _result = new CodeDto();
            _result.ApplicationIdentifier = _extracter.ExtractApplicationIdentifier();
            _result.Serial = _extracter.ExtractSerialNumber();
            _result.Identifier = _extracter.ExtractIdentifier();
            _result.SupplierCode = _extracter.ExtractSupplier();
            _result.CountryCode = _extracter.ExtractCountryCode();
        }

        public CodeToDtoMapper()
        {
        }
    }
}