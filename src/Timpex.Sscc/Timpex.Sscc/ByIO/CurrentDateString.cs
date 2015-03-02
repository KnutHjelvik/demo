using System;
using Timpex.Core.ByDateTime;

namespace Timpex.Sscc.ByIO
{
    public class CurrentDateString
    {
        private TodayDateString _todayDateString = TodayDateString.New();

        public static Func<CurrentDateString> New = () => new CurrentDateString();

        public CurrentDateString(TodayDateString todayDateString)
        {
            _todayDateString = todayDateString;
        }

        public virtual string Get()
        {
            return _todayDateString.Get();
        }


        public CurrentDateString()
        {
        }
    }
}