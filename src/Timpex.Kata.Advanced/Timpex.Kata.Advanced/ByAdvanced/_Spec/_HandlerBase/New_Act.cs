using Rhino.Mocks;
using Timpex.Kata.Advanced.ByCounter;
using Timpex.Kata.Advanced.ByPredicate;

namespace Timpex.Kata.Advanced.ByAdvanced._Spec._HandleCounter
{
    abstract class New_Act : Base_Act
    {
        protected HandlerBase Sut;
        protected TimPredicate TimPredicate = MockRepository.GenerateMock<TimPredicate>();
        protected PexPredicate PexPredicate = MockRepository.GenerateMock<PexPredicate>();
        protected Counter Counter = MockRepository.GenerateMock<Counter>();
        protected PexWordFactory PexWordFactory = MockRepository.GenerateMock<PexWordFactory>();
        protected TimWordFactory TimWordFactory = MockRepository.GenerateMock<TimWordFactory>();
        protected TimpexWordFactory TimpexWordFactory = MockRepository.GenerateMock<TimpexWordFactory>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new HandlerBase(TimPredicate,PexPredicate,TimpexWordFactory,PexWordFactory,TimWordFactory);
        }
    }


}