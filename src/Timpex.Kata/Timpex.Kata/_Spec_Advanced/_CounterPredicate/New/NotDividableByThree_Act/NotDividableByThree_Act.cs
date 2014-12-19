using System;
using Rhino.Mocks;
using Timpex.Kata.ByAdvancedTimpexPrinter2;

namespace Timpex.Kata._Spec_Advanced._CounterPredicate.New.NotDividableByThree_Act
{
    abstract class NotDividableByThree_Act:New_Act
    {
        protected Counter _counter = MockRepository.GenerateMock<Counter>();
        protected Boolean Returned;
        protected Boolean Expected = false;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            _counter.Stub(z => z.GetValue()).Return(5);
        }

        protected override void Act()
        {
            Returned = Sut.IsDividableWithThree(_counter);
        }
    }
}