using Rhino.Mocks;
using Timpex.Sscc.ByPredicate;

namespace Timpex.Sscc.ByCode._Spec._CodeListFactory
{
    abstract class New_Act : Base_Act
    {
        protected CodelistFactory Sut;
        protected EmptyPredicate EmptyPredicate = MockRepository.GenerateMock<EmptyPredicate>();
        protected CodeListWrapper CodeListWrapper = MockRepository.GenerateMock<CodeListWrapper>();
        protected CodeFactory CodeFactory = MockRepository.GenerateMock<CodeFactory>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new CodelistFactory(EmptyPredicate,CodeFactory);
        }
    }


}