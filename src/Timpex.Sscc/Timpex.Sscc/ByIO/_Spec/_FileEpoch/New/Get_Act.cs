using Rhino.Mocks;

namespace Timpex.Sscc.ByIO._Spec._FileEpoch.New
{
    abstract class Get_Act : New_Act
    {
        protected string Expected = "20111111111111";
        protected string Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            TodayDateString.Stub(x => x.Get()).Return(Expected);
        }

        protected override void Act()
        {
            Returned = Sut.Get();
        }
    }


}