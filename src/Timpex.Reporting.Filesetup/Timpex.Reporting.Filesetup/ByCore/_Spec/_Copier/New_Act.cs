using Rhino.Mocks;
using Timpex.Reporting.Filesetup.ByCore.IO;

namespace Timpex.Reporting.Filesetup.ByCore._Spec._Copier
{
    abstract class New_Act : Base_Act
    {
        protected Copier Sut;
        protected FileImpl FileImpl = MockRepository.GenerateMock<FileImpl>();
        protected PathImpl PathImpl = MockRepository.GenerateMock<PathImpl>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new Copier(FileImpl,PathImpl);
        }
    }


}