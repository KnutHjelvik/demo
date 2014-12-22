using Rhino.Mocks;
using Timpex.Kata.Advanced.ByCounter;

namespace Timpex.Kata.Advanced.ByPredicate._Spec._TimpexPredicate.New.Matches
{
    abstract class Matches_Act : New_Act
    {
        protected bool Expected = true;
        protected bool Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Counter.Stub(x => x.Count).Return(3);
            TimPredicate.Stub(x => x.Matches(Counter)).Return(true);
            PexPredicate.Stub(x => x.Matches(Counter)).Return(true);
        }

        protected override void Act()
        {
            Returned = Sut.Matches(Counter);
        }
    }


}