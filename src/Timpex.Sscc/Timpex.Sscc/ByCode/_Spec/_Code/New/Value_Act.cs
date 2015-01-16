namespace Timpex.Sscc.ByCode._Spec._Code.New
{
    abstract class Value_Act : New_Act
    {
        protected string Expected = "code";
        protected string Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Sut.value = Expected;

        }

        protected override void Act()
        {
            Returned = Sut.value;
        }
    }


}