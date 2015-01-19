namespace Timpex.Sscc.ByCode._Spec._ExtractCountryCode
{
    abstract class New_Act : Base_Act
    {
        protected ExtractCountryCode Sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new ExtractCountryCode();
        }
    }


}