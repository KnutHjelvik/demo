using Rhino.Mocks;
using Timpex.Reporting.Filesetup.ByCore;

namespace Timpex.Reporting.Filesetup.ByReporting._Spec._ReportsEngModule
{
    abstract class New_Act : Base_Act
    {
        protected CommandHandlerContainer CommandHandlerContainer = MockRepository.GenerateMock<CommandHandlerContainer>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubNew(ref CommandHandlerContainer.New,CommandHandlerContainer);
        }

        protected override void Act()
        {
            ReportsEngModule.New();
        }
    }


}