namespace Timpex.Sscc.ByCode._Spec._ExtractApplicationIdentifier
{
    abstract class New_Act : Base_Act
    {
        protected ExtractApplicationIdentifier Sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new ExtractApplicationIdentifier();
        }
    }


}