using System;
using Timpex.Core.ByDateTime;

namespace Timpex.Sscc.ByIO
{
    public class FileEpoch
    {
        private TodayDateString _todayDateString = TodayDateString.New();

        public static Func<FileEpoch> New = () => new FileEpoch();

        public FileEpoch(TodayDateString todayDateString)
        {
            _todayDateString = todayDateString;
        }

        public virtual string Get()
        {
            return _todayDateString.Get();
        }


        public FileEpoch()
        {
        }
    }
}