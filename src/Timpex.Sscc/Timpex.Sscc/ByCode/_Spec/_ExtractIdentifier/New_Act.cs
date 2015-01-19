namespace Timpex.Sscc.ByCode._Spec._ExtractIdentifier
{
    abstract class New_Act : Base_Act
    {
        protected ExtractIdentifier Sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new ExtractIdentifier();
        }
    }


}