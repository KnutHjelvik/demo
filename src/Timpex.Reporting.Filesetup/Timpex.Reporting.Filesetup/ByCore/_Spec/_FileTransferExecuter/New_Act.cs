using Rhino.Mocks;
using Timpex.Reporting.Filesetup.ByCore.IO;
using Timpex.Reporting.Filesetup.ByCore.Reading.Excluder;

namespace Timpex.Reporting.Filesetup.ByCore._Spec._FileTransferExecuter
{
    abstract class New_Act : Base_Act
    {
        protected FileTransferExecuter Sut;
        protected FileExcluder FileExcluder = MockRepository.GenerateMock<FileExcluder>();
        protected ConsoleImpl ConsoleImpl = MockRepository.GenerateMock<ConsoleImpl>();
        protected Copier Copier = MockRepository.GenerateMock<Copier>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new FileTransferExecuter(FileExcluder, Copier, ConsoleImpl);
        }
    }


}