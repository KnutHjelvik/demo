using System;
using Rhino.Mocks;
using Timpex.Kata.ByAdvancedTimpexPrinter2;

namespace Timpex.Kata._Spec_Advanced._CounterPredicate.New.DividableByThree_Act
{
    abstract class DividableByThree_Act:New_Act
    {
        protected Counter _counter = MockRepository.GenerateMock<Counter>();
        protected Boolean Returned;
        protected Boolean Expected = true;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            _counter.Stub(z => z.GetValue()).Return(6);
        }

        protected override void Act()
        {
            Returned = Sut.IsDividableWithThree(_counter);
        }
    }
}