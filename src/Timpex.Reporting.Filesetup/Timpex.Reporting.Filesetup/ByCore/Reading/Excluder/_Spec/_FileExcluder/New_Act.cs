using Rhino.Mocks;

namespace Timpex.Reporting.Filesetup.ByCore.Reading.Excluder._Spec._FileExcluder
{
    abstract class New_Act : Base_Act
    {
        protected FileExcluder Sut;
        protected FileReader FileReader = MockRepository.GenerateMock<FileReader>();
        protected ExcludeFilesByPrefix Excluder = MockRepository.GenerateMock<ExcludeFilesByPrefix>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new FileExcluder(FileReader,Excluder);
        }
    }


}