namespace Timpex.Sscc.ByCode._Spec._ExtractSerialNumber
{
    abstract class New_Act : Base_Act
    {
        protected ExtractSerialNumber Sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new ExtractSerialNumber();
        }
    }


}