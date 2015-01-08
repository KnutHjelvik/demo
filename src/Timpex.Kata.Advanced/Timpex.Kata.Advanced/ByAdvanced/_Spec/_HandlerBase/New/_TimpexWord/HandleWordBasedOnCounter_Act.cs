using System;
using Rhino.Mocks;
using Timpex.Kata.Advanced.ByAdvanced._Spec._HandleCounter;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByAdvanced._Spec._HandlerBase.New._TimpexWord
{
    abstract class HandleWordBasedOnCounter_Act : New_Act
    {
        protected TimpexWord Expected = MockRepository.GenerateMock<TimpexWord>();
        protected Word Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Counter.Stub(x => x.Count).Return(15);
            TimPredicate.Stub(x => x.Matches(Counter)).Return(true);
            PexPredicate.Stub(x => x.Matches(Counter)).Return(true);
            TimpexWordFactory.Stub(x => x.Create()).Return(Expected);
        }

        protected override void Act()
        {
            Returned = Sut.HandleWordBasedOnCounter(Counter);
        }
    }


}