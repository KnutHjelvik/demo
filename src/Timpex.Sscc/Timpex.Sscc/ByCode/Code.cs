using System;

namespace Timpex.Sscc.ByCode
{
    public class Code
    {
        public virtual string value {  set; get; }

        public static Func<Code> New = () => new Code();

        public Code(string code)
        {
            value = code;
        }

        public virtual void Setup(string code)
        {
            value = code;
        }

        public Code()
        {
        }
    }
}