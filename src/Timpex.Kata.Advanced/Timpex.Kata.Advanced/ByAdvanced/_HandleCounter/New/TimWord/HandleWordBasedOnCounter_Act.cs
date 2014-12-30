using System;
using Rhino.Mocks;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByAdvanced._HandleCounter.New.TimWord
{
    abstract class HandleWordBasedOnCounter_Act : New_Act
    {
        protected String Expected = "tim";
        protected Word Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Counter.Stub(x => x.Count).Return(3);
            TimPredicate.Stub(x => x.Matches(Counter)).Return(true);
            PexPredicate.Stub(x => x.Matches(Counter)).Return(false);

        }

        protected override void Act()
        {
            Returned = Sut.HandleWordBasedOnCounter(Counter);
        }
    }


}