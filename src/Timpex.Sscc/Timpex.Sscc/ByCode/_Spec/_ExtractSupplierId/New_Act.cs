namespace Timpex.Sscc.ByCode._Spec._ExtractSupplierId
{
    abstract class New_Act : Base_Act
    {
        protected ExtractSupplier Sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new ExtractSupplier();
        }
    }


}