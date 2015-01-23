using System;

namespace Timpex.Core.ByDateTime
{
    public class TodayDateString
    {
        private TodayGenerator _todayGenerator = TodayGenerator.New();
        private AdvancedDateTimeConverter _advancedDateTimeConverter = AdvancedDateTimeConverter.New();

        public static Func<TodayDateString> New = () => new TodayDateString();

        public TodayDateString(AdvancedDateTimeConverter advancedDateTimeConverter, TodayGenerator todayGenerator)
        {
            _todayGenerator = todayGenerator;
            _advancedDateTimeConverter = advancedDateTimeConverter;
        }

        public virtual string Get()
        {
            var date = _todayGenerator.Generate();
            return _advancedDateTimeConverter.Convert(date);
        }

        public TodayDateString()
        {
        }
    }
}