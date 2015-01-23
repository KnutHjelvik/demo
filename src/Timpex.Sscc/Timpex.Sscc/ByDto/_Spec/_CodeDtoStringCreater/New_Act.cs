using Rhino.Mocks;
using Timpex.Sscc.ByIO;

namespace Timpex.Sscc.ByDto._Spec._CodeDtoStringCreater
{
    abstract class New_Act : Base_Act
    {
        protected CodeDtoStringCreater Sut;
        protected Strings Strings = MockRepository.GenerateMock<Strings>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new CodeDtoStringCreater(Strings);
        }
    }


}