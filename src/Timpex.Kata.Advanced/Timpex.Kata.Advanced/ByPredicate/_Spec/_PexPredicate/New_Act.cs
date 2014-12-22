namespace Timpex.Kata.Advanced.ByPredicate._Spec._PexPredicate
{
    abstract class New_Act : Base_Act
    {
        protected PredicateCore Sut;
        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new PexPredicate();
        }
    }


}