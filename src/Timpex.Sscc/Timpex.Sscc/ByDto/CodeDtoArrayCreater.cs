using System;
using System.Collections.Generic;

namespace Timpex.Sscc.ByDto
{
    public class CodeDtoArrayCreater
    {
        private CodeDtoStringCreater _innerCreater = CodeDtoStringCreater.New();

        public static Func<CodeDtoArrayCreater> New = () => new CodeDtoArrayCreater();

        public CodeDtoArrayCreater(CodeDtoStringCreater innerCreater)
        {
            _innerCreater = innerCreater;
        }

        public virtual string[] Create(List<CodeDto> dtos)
        {
            string[] result = new string[dtos.Count];
            for (int i = 0; i < dtos.Count; i++)
            {
                var dto = dtos[i];
                result[i] = _innerCreater.Create(dto);
            }
            return result;
        }

        public CodeDtoArrayCreater()
        {
        }
    }
}