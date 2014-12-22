using Rhino.Mocks;
using Timpex.Kata.Advanced.ByCounter;
using Timpex.Kata.Advanced.ByPredicate;
using Timpex.Kata.Advanced.ByPrinter;

namespace Timpex.Kata.Advanced._Spec._Timpex
{
    abstract class New_Act : Base_Act
    {
        protected Timpex Sut;
        protected CounterPrinter CounterPrinter = MockRepository.GenerateMock<CounterPrinter>();
        protected TimpexPrinter TimpexPrinter = MockRepository.GenerateMock<TimpexPrinter>();
        protected TimpexPredicate TimpexPredicate = MockRepository.GenerateMock<TimpexPredicate>();
        protected Counter Counter = MockRepository.GenerateMock<Counter>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new Timpex(TimpexPredicate,CounterPrinter,TimpexPrinter,Counter);
        }
    }


}