using Rhino.Mocks;
using Timpex.Reporting.Filesetup.ByCore.Factory;
using Timpex.Reporting.Filesetup.ByCore.Folder;
using Timpex.Reporting.Filesetup.ByCore.IO;

namespace Timpex.Reporting.Filesetup.ByCore.Reading._Spec._FileReader
{
    abstract class New_Act : Base_Act
    {
        protected FileReader Sut;
        protected DirectoryImpl DirectoryImpl = MockRepository.GenerateMock<DirectoryImpl>();
        protected FileInfoFactory FileInfoFactory = MockRepository.GenerateMock<FileInfoFactory>();
        protected FolderSettings FolderSettings = MockRepository.GenerateMock<FolderSettings>();


        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new FileReader(FolderSettings,DirectoryImpl,FileInfoFactory);
        }
    }


}