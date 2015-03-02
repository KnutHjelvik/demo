using Rhino.Mocks;
using Timpex.Reporting.Filesetup.ByCore;

namespace Timpex.Reporting.Filesetup.ByReporting.All._Spec
{
    abstract class New_Act : Base_Act
    {
        protected StartPointReporting Sut = StartPointReporting.New();
        protected CommandHandlerContainer CommandHandlerContainer = MockRepository.GenerateMock<CommandHandlerContainer>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new StartPointReporting(CommandHandlerContainer);
        }
    }


}