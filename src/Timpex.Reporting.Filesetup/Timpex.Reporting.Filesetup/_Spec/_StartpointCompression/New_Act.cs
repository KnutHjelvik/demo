using Rhino.Mocks;
using Timpex.Reporting.Filesetup.ByCore.Folder;
using Timpex.Reporting.Filesetup.ByCore.IO;

namespace Timpex.Reporting.Filesetup._Spec._StartpointCompression
{
    abstract class New_Act : Base_Act
    {
        protected ZipFileImpl ZipFileImpl = MockRepository.GenerateMock<ZipFileImpl>();
        protected DirectoryImpl DirectoryImpl = MockRepository.GenerateMock<DirectoryImpl>();
        protected FileImpl FileImpl = MockRepository.GenerateMock<FileImpl>();
        protected StartpointCompression Sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
           Sut = new StartpointCompression(ZipFileImpl,DirectoryImpl,FileImpl); 
        }
    }


}