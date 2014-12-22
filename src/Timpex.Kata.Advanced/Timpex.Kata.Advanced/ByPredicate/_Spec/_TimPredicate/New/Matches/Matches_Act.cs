using Rhino.Mocks;
using Timpex.Kata.Advanced.ByCounter;

namespace Timpex.Kata.Advanced.ByPredicate._Spec._TimPredicate.New.Matches
{
    abstract class Matches_Act : New_Act
    {
        protected Counter Counter = MockRepository.GenerateMock<Counter>();
        protected bool Expected = true;
        protected bool Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Counter.Stub(x => x.Count).Return(3);

        }

        protected override void Act()
        {
            Returned = Sut.Matches(Counter);
        }
    }


}