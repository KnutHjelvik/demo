using Rhino.Mocks;

namespace Timpex.Sscc.ByCode._Spec._CodeFactory
{
    abstract class New_Act : Base_Act
    {
        protected CodeFactory Sut { get; set; }
        protected SpaceRemover SpaceRemover = MockRepository.GenerateMock<SpaceRemover>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new CodeFactory(SpaceRemover);
        }
    }


}