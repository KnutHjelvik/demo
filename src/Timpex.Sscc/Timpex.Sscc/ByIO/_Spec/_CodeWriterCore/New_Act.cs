using Rhino.Mocks;
using Timpex.IO.ByIO;

namespace Timpex.Sscc.ByIO._Spec._CodeWriterCore
{
    abstract class New_Act : Base_Act
    {
        protected FilenameGenerator FilenameGenerator = MockRepository.GenerateMock<FilenameGenerator>();
        protected FileWriter FileWriter = MockRepository.GenerateMock<FileWriter>();
        protected CodeWriterCore Sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new CodeWriterCore(FileWriter,FilenameGenerator);
        }
    }


}