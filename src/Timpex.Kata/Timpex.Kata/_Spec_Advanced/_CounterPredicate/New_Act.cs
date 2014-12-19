using Timpex.Kata.ByAdvancedTimpexPrinter2;

namespace Timpex.Kata._Spec_Advanced._CounterPredicate
{
    abstract class New_Act:Base_Act
    {
        protected CounterPredicate Sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new CounterPredicate();
        }
    }
}