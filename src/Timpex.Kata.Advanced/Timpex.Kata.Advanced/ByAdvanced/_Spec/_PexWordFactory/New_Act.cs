namespace Timpex.Kata.Advanced.ByAdvanced._Spec._PexWordFactory
{
    abstract class New_Act : Base_Act
    {
        protected PexWordFactory Sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new PexWordFactory();
        }
    }


}