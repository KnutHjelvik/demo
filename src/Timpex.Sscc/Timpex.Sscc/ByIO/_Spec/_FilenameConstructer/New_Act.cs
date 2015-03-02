using Rhino.Mocks;

namespace Timpex.Sscc.ByIO._Spec._FilenameConstructer
{
    abstract class New_Act : Base_Act
    {
        protected FilenameConstructer Sut;
        protected CurrentDateString CurrentDateString = MockRepository.GenerateMock<CurrentDateString>();
        protected FilePrefix FilePrefix = MockRepository.GenerateMock<FilePrefix>();
        protected FileExtension FileExtension = MockRepository.GenerateMock<FileExtension>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new FilenameConstructer(FileExtension,CurrentDateString,FilePrefix);
        }
    }


}   