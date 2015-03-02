using Rhino.Mocks;

namespace Timpex.Reporting.Filesetup.ByCore.Factory._FileExtensionFactory
{
    abstract class New_Act : Base_Act
    {
        protected FileExtensionFactory Sut;
        protected FilenameFactory FilenameFactory = MockRepository.GenerateMock<FilenameFactory>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new FileExtensionFactory(FilenameFactory);
        }
    }


}