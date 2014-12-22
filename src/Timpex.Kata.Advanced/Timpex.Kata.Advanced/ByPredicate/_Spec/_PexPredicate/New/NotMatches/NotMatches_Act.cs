using Rhino.Mocks;
using Timpex.Kata.Advanced.ByCounter;

namespace Timpex.Kata.Advanced.ByPredicate._Spec._PexPredicate.New.NotMatches
{
    abstract class NotMatches_Act : _TimPredicate.New_Act
    {
        protected Counter Counter = MockRepository.GenerateMock<Counter>();
        protected bool Expected = false;
        protected bool Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Counter.Stub(x => x.Count).Return(4);

        }

        protected override void Act()
        {
            Returned = Sut.Matches(Counter);
        }
    }


}