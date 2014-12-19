using System;
using Rhino.Mocks;
using Timpex.Kata.ByAdvancedTimpexPrinter2;

namespace Timpex.Kata._Spec_Advanced._CounterPredicate.New.NotDividableByFive_Act
{
    abstract class NotDividableByFive_Act : New_Act
    {
        protected Counter _counter = MockRepository.GenerateMock<Counter>();
        protected Boolean Returned;
        protected Boolean Expected = false;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            _counter.Stub(z => z.GetValue()).Return(7);
        }

        protected override void Act()
        {
            Returned = Sut.IsDividableWithFive(_counter);
        }
    }
}