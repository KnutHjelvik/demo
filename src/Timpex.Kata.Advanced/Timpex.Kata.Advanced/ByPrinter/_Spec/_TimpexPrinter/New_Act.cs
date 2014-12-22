using Rhino.Mocks;
using Timpex.Kata.Advanced.ByCounter;
using Timpex.Kata.Advanced.ByPredicate;

namespace Timpex.Kata.Advanced.ByPrinter._Spec._TimpexPrinter
{
    abstract class New_Act : Base_Act
    {

        protected PredicateCore PexPredicate = MockRepository.GenerateMock<PexPredicate>();
        protected PredicateCore TimPredicate = MockRepository.GenerateMock<TimPredicate>();
        protected TimPrinter TimPrinter = MockRepository.GenerateMock<TimPrinter>();
        protected PexPrinter PexPrinter = MockRepository.GenerateMock<PexPrinter>();
        protected TimAndPexPrinter TimAndPexPrinter = MockRepository.GenerateMock<TimAndPexPrinter>();
        protected Counter Counter = MockRepository.GenerateMock<Counter>();

        protected TimpexPrinter Sut; 

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new TimpexPrinter(PexPredicate,PexPrinter,TimAndPexPrinter,TimPredicate,TimPrinter);
        }
    }


}