using Rhino.Mocks;

namespace Timpex.Core.ByDateTime._Spec._DateAndTimeStringConverter
{
    abstract class New_Act : Base_Act
    {
        protected TodayDateString Sut;
        protected AdvancedDateTimeConverter AdvancedDateTimeConverter = MockRepository.GenerateMock<AdvancedDateTimeConverter>();
        protected TodayGenerator TodayGenerator = MockRepository.GenerateMock<TodayGenerator>();
 

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new TodayDateString(AdvancedDateTimeConverter,TodayGenerator);
        }
    }


}