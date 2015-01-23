namespace Timpex.Sscc.ByIO._Spec._FilePrefix.New
{
    abstract class Get_Act : New_Act
    {
        protected string Expected = "valid_sscc_";
        protected string Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Returned = Sut.Get();
        }
    }


}