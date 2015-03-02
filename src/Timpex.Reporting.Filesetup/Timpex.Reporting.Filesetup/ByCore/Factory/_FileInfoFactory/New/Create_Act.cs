using Rhino.Mocks;
using Timpex.Reporting.Filesetup.ByCore.IO;

namespace Timpex.Reporting.Filesetup.ByCore.Factory._FileInfoFactory.New
{
    abstract class Create_Act : New_Act
    {
        protected string Path = "Path";
        protected string Extension = ".txt";
        protected string Name = "Name";
        protected FileInformation Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            FilenameFactory.Stub(x => x.Create(Path)).Return(Name);
            FileExtensionFactory.Stub(x => x.Create(Path)).Return(Extension);
        }

        protected override void Act()
        {
            Returned = Sut.Create(Path);
        }
    }


}