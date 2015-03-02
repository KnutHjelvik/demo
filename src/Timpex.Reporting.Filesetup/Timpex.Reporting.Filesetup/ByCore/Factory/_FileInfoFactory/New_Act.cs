using Rhino.Mocks;

namespace Timpex.Reporting.Filesetup.ByCore.Factory._FileInfoFactory
{
    abstract class New_Act : Base_Act
    {
        protected FileInfoFactory Sut;
        protected FileExtensionFactory FileExtensionFactory = MockRepository.GenerateMock<FileExtensionFactory>();
        protected FilenameFactory FilenameFactory = MockRepository.GenerateMock<FilenameFactory>();


        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new FileInfoFactory(FileExtensionFactory,FilenameFactory);
        }
    }


}