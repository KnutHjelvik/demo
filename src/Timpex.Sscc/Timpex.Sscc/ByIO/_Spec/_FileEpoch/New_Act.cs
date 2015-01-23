using Rhino.Mocks;
using Timpex.Core.ByDateTime;

namespace Timpex.Sscc.ByIO._Spec._FileEpoch
{
    abstract class New_Act : Base_Act
    {

        protected FileEpoch Sut;
        protected TodayDateString TodayDateString = MockRepository.GenerateMock<TodayDateString>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new FileEpoch(TodayDateString);
        }
    }


}   