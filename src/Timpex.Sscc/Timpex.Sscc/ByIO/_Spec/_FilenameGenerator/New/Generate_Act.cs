using Rhino.Mocks;

namespace Timpex.Sscc.ByIO._Spec._FilenameGenerator.New
{
    abstract class Generate_Act : New_Act
    {
        protected string Expected = "filename";
        protected string Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            FilenameConstructer.Stub(x => x.Construct()).Return(Expected);
        }

        protected override void Act()
        {
            Returned = Sut.Generate();
        }
    }


}