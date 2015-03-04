using Rhino.Mocks;
using Timpex.Reporting.Filesetup.ByCore.IO;

namespace Timpex.Reporting.Filesetup._Spec._StartpointInformation
{
    abstract class New_Act : Base_Act
    {
        protected ConsoleImpl ConsoleImpl = MockRepository.GenerateMock<ConsoleImpl>();
        protected StartpointInformation Sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new StartpointInformation(ConsoleImpl);
        }
    }


}