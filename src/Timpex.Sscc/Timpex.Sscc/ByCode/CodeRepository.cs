using System;

namespace Timpex.Sscc.ByCode
{
    public class CodeRepository
    {
        public static Func<CodeRepository> New = () => new CodeRepository();

        public string Path = "C:\\SSCC.txt";
    }
}