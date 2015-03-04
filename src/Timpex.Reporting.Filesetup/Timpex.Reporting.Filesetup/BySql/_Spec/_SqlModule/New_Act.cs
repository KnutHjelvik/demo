using Rhino.Mocks;
using Timpex.Reporting.Filesetup.ByCore;

namespace Timpex.Reporting.Filesetup.BySql._Spec._SqlModule
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
            SqlModule.New();
        }
    }


}