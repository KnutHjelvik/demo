using Rhino.Mocks;

namespace Timpex.Reporting.Filesetup.ByCore.Factory._AcceptedFilePrefixFactory.New
{
    abstract class Create_Act : New_Act
    {
        protected string[] Prefixes = {"txt","dtsx"};
        protected AcceptedPrefix Expected = MockRepository.GenerateMock<AcceptedPrefix>();
        protected AcceptedPrefix Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubNew(ref AcceptedPrefix.New, Expected);
        }

        protected override void Act()
        {
            Returned = Sut.Create(Prefixes);
        }
    }


}