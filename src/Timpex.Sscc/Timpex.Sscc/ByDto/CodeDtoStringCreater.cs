using System;
using Timpex.Sscc.ByIO;

namespace Timpex.Sscc.ByDto
{
    public class CodeDtoStringCreater
    {
        private string _result;
        private CodeDto _codeDto;
        private string NewLine = Environment.NewLine;
        private StringConstructer _stringConstructer = StringConstructer.New();

        public static Func<CodeDtoStringCreater> New = () => new CodeDtoStringCreater();

        public CodeDtoStringCreater(StringConstructer stringConstructer)
        {
            _stringConstructer = stringConstructer;
        }

        public virtual string Create(CodeDto dto)
        {
            _codeDto = dto;
            CreateCore();
            return _result;
        }

        private void CreateCore()
        {
            var ApplicationIdentifier = "Application identifier: " + _codeDto.ApplicationIdentifier + NewLine;
            var Identifier = "Identifier: " + _codeDto.Identifier + NewLine;
            var CountryCode = "CountryCode: " + _codeDto.CountryCode + NewLine;
            var Supplier = "Supplier: " + _codeDto.SupplierCode + NewLine;
            var Serial = "Serial: " + _codeDto.Serial + NewLine + NewLine;
            _result = _stringConstructer.Construct(ApplicationIdentifier, Identifier, CountryCode, Supplier, Serial);
        }

        public CodeDtoStringCreater()
        {
        }
    }
}