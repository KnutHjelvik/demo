using System;

namespace Timpex.Core.ByStrings
{
    public class Strings
    {
        private string _result;

        public static Func<Strings> New = () => new Strings();

        public virtual string Concat(params string[] strings)
        {
            foreach (var str in strings)
            {
                _result = _result + str;
            }
            return _result;
        }

        public Strings()
        {
        }
    }
}