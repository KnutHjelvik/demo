namespace Timpex.Kata.Advanced.ByWord._Spec._WordStringTrimmer
{
    abstract class New_Act : Base_Act
    {
        protected WordStringTrimmer Sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new WordStringTrimmer();
        }
    }


}