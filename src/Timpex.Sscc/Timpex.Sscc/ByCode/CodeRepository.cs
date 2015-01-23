using System;

namespace Timpex.Sscc.ByCode
{
    public class CodeRepository
    {
        public static Func<CodeRepository> New = () => new CodeRepository();

        public virtual string GetLocation()
        {
            return "C:\\SSCC.txt";
        }
 
    }
}