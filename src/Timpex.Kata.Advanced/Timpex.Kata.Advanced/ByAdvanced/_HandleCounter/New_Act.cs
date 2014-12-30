using Rhino.Mocks;
using Timpex.Kata.Advanced.ByCounter;
using Timpex.Kata.Advanced.ByPredicate;

namespace Timpex.Kata.Advanced.ByAdvanced._HandleCounter
{
    abstract class New_Act : Base_Act
    {
        protected HandleCounter Sut;
        protected TimPredicate TimPredicate = MockRepository.GenerateMock<TimPredicate>();
        protected PexPredicate PexPredicate = MockRepository.GenerateMock<PexPredicate>();
        protected Counter Counter = MockRepository.GenerateMock<Counter>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new HandleCounter(TimPredicate,PexPredicate);
        }
    }


}