namespace Timpex.Sscc.ByPredicate._Spec._ApplicationIdentifierPredicate
{
    abstract class New_Act : Base_Act
    {
        protected ApplicationIdentifierPredicate Sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new ApplicationIdentifierPredicate();
        }
    }


}