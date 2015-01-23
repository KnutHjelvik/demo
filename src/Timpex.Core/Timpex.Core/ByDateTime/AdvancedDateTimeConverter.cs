using System;

namespace Timpex.Core.ByDateTime
{
    public class AdvancedDateTimeConverter
    {
        public static Func<AdvancedDateTimeConverter> New = () => new AdvancedDateTimeConverter();

        public virtual string Convert(DateTime dateTime)
        {
            return dateTime.ToString("yyyyMMddHHmmss");
        }

        public AdvancedDateTimeConverter()
        {
        }
    }
}