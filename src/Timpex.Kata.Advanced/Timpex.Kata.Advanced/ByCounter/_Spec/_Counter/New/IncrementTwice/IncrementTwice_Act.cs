namespace Timpex.Kata.Advanced.ByCounter._Spec._Counter.New.IncrementTwice
{
    abstract class IncrementTwice_Act : New_Act
    {
        protected int Expected = 1;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut.IncrementCount();
            Sut.IncrementCount();
        }
    }


}