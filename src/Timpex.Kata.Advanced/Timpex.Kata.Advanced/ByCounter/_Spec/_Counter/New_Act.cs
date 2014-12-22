namespace Timpex.Kata.Advanced.ByCounter._Spec._Counter
{
    abstract class New_Act : Base_Act
    {
        protected Counter Sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new Counter();
        }
    }


}