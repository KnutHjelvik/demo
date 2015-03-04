using Rhino.Mocks;
using Timpex.Reporting.Filesetup.ByCore;

namespace Timpex.Reporting.Filesetup.All.Startpoints._Spec._StartpointNorwegianStandard
{
    abstract class New_Act : Base_Act
    {
        protected StartpointEnglishExtended Sut;
        protected CommandHandlerContainer CommandHandlerContainer = MockRepository.GenerateMock<CommandHandlerContainer>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new StartpointEnglishExtended(CommandHandlerContainer);
        }
    }


}