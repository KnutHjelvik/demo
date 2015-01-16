namespace Timpex.Sscc.ByPredicate._Spec._LengthOfCodePredicate
{
    abstract class New_Act : Base_Act
    {
        protected LengthOfCodePredicate Sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new LengthOfCodePredicate();
        }
    }


}