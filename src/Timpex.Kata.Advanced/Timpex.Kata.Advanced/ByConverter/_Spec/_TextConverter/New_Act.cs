namespace Timpex.Kata.Advanced.ByConverter._Spec._TextConverter
{
    abstract class New_Act : Base_Act
    {
        
        protected TextConverter Sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new TextConverter();
        }
    }


}