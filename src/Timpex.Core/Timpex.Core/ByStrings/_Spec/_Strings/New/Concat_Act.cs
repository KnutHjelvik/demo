namespace Timpex.Core.ByStrings._Spec._Strings.New
{
    abstract class Concat_Act : New_Act
    {
        protected string Expected = "ABC";
        private string String1 = "A";
        private string String2 = "B";
        private string String3 = "C";
        protected string Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Returned = Sut.Concat(String1, String2, String3);
        }
    }


}