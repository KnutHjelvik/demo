using System;
using System.Text.RegularExpressions;

namespace Timpex.Sscc.ByCode
{
    public class SpaceRemover
    {
        public static Func<SpaceRemover> New = () => new SpaceRemover();

        public virtual string Remove(string code)
        {
            return Regex.Replace(code, @"\s+", "");
        }

        public SpaceRemover()
        {
        }
    }
}