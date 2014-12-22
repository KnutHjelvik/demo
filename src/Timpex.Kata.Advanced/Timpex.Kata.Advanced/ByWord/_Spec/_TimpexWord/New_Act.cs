namespace Timpex.Kata.Advanced.ByWord._Spec._TimpexWord
{
    abstract class New_Act:Base_Act
    {
        protected Word Sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new TimpexWord();
        }
    }
}