using System;
using Timpex.Sscc.ByCode;

namespace Timpex.Sscc.ByDto
{
    public class CodeDtoFactory
    {
        private CodeToDtoMapper _codeToDtoMapper = CodeToDtoMapper.New();

        public static Func<CodeDtoFactory> New = () => new CodeDtoFactory();

        public CodeDtoFactory(CodeToDtoMapper mapper)
        {
            _codeToDtoMapper = mapper;
        }

        public virtual CodeDto Create(Code RawCode)
        {
            return _codeToDtoMapper.Map(RawCode);
        }

        public CodeDtoFactory()
        {
        }
    }
}