using Timpex.Kata.ByAdvancedTimpexPrinter2;

namespace Timpex.Kata._Spec_Advanced.NumberCounter
{
    abstract class New_Act:Base_Act
    {
        protected ByAdvancedTimpexPrinter2.NumberCounter _sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            _sut = new ByAdvancedTimpexPrinter2.NumberCounter();
        }
    }
}
