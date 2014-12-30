using System;
using Rhino.Mocks;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByAdvanced._HandleCounter.New.PexWord
{
    abstract class HandleWordBasedOnCounter_Act : New_Act
    {
        protected String Expected = "pex";
        protected Word Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Counter.Stub(x => x.Count).Return(5);
            TimPredicate.Stub(x => x.Matches(Counter)).Return(false);
            PexPredicate.Stub(x => x.Matches(Counter)).Return(true);

        }

        protected override void Act()
        {
            Returned = Sut.HandleWordBasedOnCounter(Counter);
        }
    }


}