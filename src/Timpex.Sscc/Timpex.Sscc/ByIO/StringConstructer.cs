using System;

namespace Timpex.Sscc.ByIO
{
    public class StringConstructer
    {
        private string _result;

        public static Func<StringConstructer> New = () => new StringConstructer();

        public virtual string Construct(params string[] strings)
        {
            foreach (var str in strings)
            {
                _result = _result + str;
            }
            return _result;
        }

        public StringConstructer()
        {
        }
    }
}