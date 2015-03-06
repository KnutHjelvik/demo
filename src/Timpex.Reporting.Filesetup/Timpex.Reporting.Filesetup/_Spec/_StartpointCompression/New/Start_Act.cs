using Rhino.Mocks;

namespace Timpex.Reporting.Filesetup._Spec._StartpointCompression.New
{
    abstract class Start_Act : New_Act
    {
        protected static string source = "source";
        protected string dest = "destination";

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            DirectoryImpl.Stub(x => x.CreateRootDirectory()).Return(source);
            DirectoryImpl.Stub(x => x.Root()).Return(dest);
        }

        protected override void Act()
        {
            Sut.Start();
        }
    }


}