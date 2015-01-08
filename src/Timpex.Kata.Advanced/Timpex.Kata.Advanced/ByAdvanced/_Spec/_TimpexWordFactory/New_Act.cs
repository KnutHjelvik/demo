namespace Timpex.Kata.Advanced.ByAdvanced._Spec._TimpexWordFactory
{
    abstract class New_Act : Base_Act
    {
        protected TimpexWordFactory Sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new TimpexWordFactory();
        }
    }


}