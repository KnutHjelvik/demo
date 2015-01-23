using System;

namespace Timpex.Sscc.ByDto
{
    public class CodeDto
    {
        public static Func<CodeDto> New = () => new CodeDto();

        public virtual string ApplicationIdentifier { get; set; }
        public virtual string Identifier { get; set; }
        public virtual string CountryCode { get; set; }
        public virtual string SupplierCode { get; set; }
        public virtual string Serial { get; set; }

        public CodeDto()
        {
        }
    }
}