using Rhino.Mocks;
using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.BySql;

namespace Timpex.Reporting.Filesetup.ByDeployment._Spec._DeploymentModule
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
            DeploymentModule.New();
        }
    }


}