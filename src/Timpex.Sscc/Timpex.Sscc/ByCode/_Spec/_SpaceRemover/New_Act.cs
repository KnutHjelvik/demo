namespace Timpex.Sscc.ByCode._Spec._SpaceRemover
{
    abstract class New_Act : Base_Act
    {
        protected SpaceRemover Sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new SpaceRemover();
        }
    }


}