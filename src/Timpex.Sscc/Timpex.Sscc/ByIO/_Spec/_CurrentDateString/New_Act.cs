using Rhino.Mocks;
using Timpex.Core.ByDateTime;

namespace Timpex.Sscc.ByIO._Spec._CurrentDateString
{
    abstract class New_Act : Base_Act
    {

        protected CurrentDateString Sut;
        protected TodayDateString TodayDateString = MockRepository.GenerateMock<TodayDateString>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new CurrentDateString(TodayDateString);
        }
    }


}   