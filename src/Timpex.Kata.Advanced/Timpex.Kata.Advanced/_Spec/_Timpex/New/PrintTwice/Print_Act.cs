﻿using System;
using Rhino.Mocks;

namespace Timpex.Kata.Advanced._Spec._Timpex.New.PrintTwice
{
    abstract class Print_Act : New_Act
    {
        protected String Expected = "2";
        protected String Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Counter.Stub(x => x.Count).Return(2);
            TimpexPredicate.Stub(x => x.Matches(Counter)).Return(false);
            CounterPrinter.Stub(x => x.Print(Counter)).Return("2");
        }

        protected override void Act()
        {
            Returned = Sut.Print();
        }
    }


}