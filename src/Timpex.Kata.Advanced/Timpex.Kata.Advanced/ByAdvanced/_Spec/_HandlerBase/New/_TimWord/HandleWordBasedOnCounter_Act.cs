using System;
using Rhino.Mocks;
using Timpex.Kata.Advanced.ByAdvanced._Spec._HandleCounter;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByAdvanced._Spec._HandlerBase.New._TimWord
{
    abstract class HandleWordBasedOnCounter_Act : New_Act
    {
        protected TimWord Expected = MockRepository.GenerateMock<TimWord>();
        protected Word Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Counter.Stub(x => x.Count).Return(3);
            TimPredicate.Stub(x => x.Matches(Counter)).Return(true);
            PexPredicate.Stub(x => x.Matches(Counter)).Return(false);
            TimWordFactory.Stub(x => x.Create()).Return(Expected);

        }

        protected override void Act()
        {
            Returned = Sut.HandleWordBasedOnCounter(Counter);
        }
    }


}