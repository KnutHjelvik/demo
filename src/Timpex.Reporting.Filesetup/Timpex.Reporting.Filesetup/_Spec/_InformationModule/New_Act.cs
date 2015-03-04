using Rhino.Mocks;
using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.BySql;

namespace Timpex.Reporting.Filesetup._Spec._InformationModule
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
            InformationModule.New();
        }
    }


}