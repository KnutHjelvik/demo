using System;

namespace Timpex.Core.ByDateTime
{
    public class TodayGenerator
    {
        public static Func<TodayGenerator> New = () => new TodayGenerator();

        public virtual DateTime Generate()
        {
            return DateTime.Today;
        }

        public TodayGenerator()
        {
        }
    }
}