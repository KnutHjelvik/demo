﻿using Rhino.Mocks;

namespace Timpex.Kata.Advanced.ByPredicate._Spec._TimpexPredicate.New.MatchesTim
{
    abstract class MatchesTim_Act : New_Act
    {
        protected bool Expected = true;
        protected bool Returned;

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
            Returned = Sut.Matches(Counter);
        }
    }


}