namespace Timpex.Sscc.ByCode._Spec._Code
{
    abstract class New_Act : Base_Act
    {
        protected Code Sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new Code();
        }
    }


}