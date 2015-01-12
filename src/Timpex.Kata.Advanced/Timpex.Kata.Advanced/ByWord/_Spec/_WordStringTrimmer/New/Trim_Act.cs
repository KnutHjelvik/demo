namespace Timpex.Kata.Advanced.ByWord._Spec._WordStringTrimmer.New
{
    abstract class Trim_Act : New_Act
    {
        protected string Expected = "word1 word2 word3";
        protected string Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Returned = Sut.TrimString("word1 word2 word3 ");
        }
    }


}