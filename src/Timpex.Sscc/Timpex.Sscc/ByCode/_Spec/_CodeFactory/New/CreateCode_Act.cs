using Rhino.Mocks;

namespace Timpex.Sscc.ByCode._Spec._CodeFactory.New
{
    abstract class CreateCode_Act : New_Act
    {
        protected string code = "code";
        protected Code RetunrnedInstance { get; set; }
        protected Code ExpectedInstance = MockRepository.GenerateMock<Code>();



        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubNew(ref Code.New, ExpectedInstance);

        }

        protected override void Act()
        {
            RetunrnedInstance = Sut.CreateCode(code);
        }
    }


}