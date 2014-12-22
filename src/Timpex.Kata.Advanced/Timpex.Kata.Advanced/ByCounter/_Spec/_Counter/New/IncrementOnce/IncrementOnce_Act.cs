namespace Timpex.Kata.Advanced.ByCounter._Spec._Counter.New.IncrementOnce
{
    abstract class IncrementOnce_Act : New_Act
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
        }
    }


}