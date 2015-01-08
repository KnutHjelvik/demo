namespace Timpex.Kata.Advanced.ByAdvanced._Spec._TimWordFactory
{
    abstract class New_Act : Base_Act
    {
        protected TimWordFactory Sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new TimWordFactory();
        }
    }


}