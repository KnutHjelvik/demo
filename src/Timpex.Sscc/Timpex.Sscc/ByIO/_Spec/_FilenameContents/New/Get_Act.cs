using Rhino.Mocks;

namespace Timpex.Sscc.ByIO._Spec._FilenameContents.New
{
    abstract class Get_Act : New_Act
    {
        protected string Expected = "2011";
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