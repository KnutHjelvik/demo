using Rhino.Mocks;

namespace Timpex.Reporting.Filesetup.ByCore.Factory._FileExtensionFactory.New
{
    abstract class Create_Act : New_Act
    {
        protected string Path = "C:\\test\\test.txt";
        protected string Filename = "test.txt";
        protected string Expected = ".txt";
        protected string Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            FilenameFactory.Stub(x => x.Create(Path)).Return(Filename);
        }

        protected override void Act()
        {
            Returned = Sut.Create(Path);
        }
    }


}