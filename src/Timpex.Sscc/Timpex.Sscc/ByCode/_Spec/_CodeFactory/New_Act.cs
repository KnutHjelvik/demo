namespace Timpex.Sscc.ByCode._Spec._CodeFactory
{
    abstract class New_Act : Base_Act
    {
        protected CodeFactory Sut { get; set; }

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new CodeFactory();
        }
    }


}