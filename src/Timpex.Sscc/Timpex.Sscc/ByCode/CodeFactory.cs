using System;

namespace Timpex.Sscc.ByCode
{
    public class CodeFactory
    {
        public static Func<CodeFactory> New = () => new CodeFactory();

        public virtual Code CreateCode(string code)
        {
            var instance = Code.New();
            instance.Setup(code);
            return instance;
        } 
    }
}