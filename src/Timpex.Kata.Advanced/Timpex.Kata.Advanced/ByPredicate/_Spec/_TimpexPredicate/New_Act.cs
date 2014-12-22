using Rhino.Mocks;
using Timpex.Kata.Advanced.ByCounter;

namespace Timpex.Kata.Advanced.ByPredicate._Spec._TimpexPredicate
{
    abstract class New_Act : Base_Act
    {
        protected PredicateCore Sut;
        protected PredicateCore TimPredicate = MockRepository.GenerateMock<TimPredicate>();
        protected PredicateCore PexPredicate = MockRepository.GenerateMock<PexPredicate>();
        protected Counter Counter = MockRepository.GenerateMock<Counter>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new TimpexPredicate(TimPredicate, PexPredicate);
        }
    }


}