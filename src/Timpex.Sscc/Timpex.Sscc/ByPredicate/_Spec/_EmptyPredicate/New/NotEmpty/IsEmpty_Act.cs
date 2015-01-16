namespace Timpex.Sscc.ByPredicate._Spec._EmptyPredicate.New.NotEmpty
{
    abstract class IsEmpty_Act : New_Act
    {
        protected bool Expected = false;
        protected bool Returned;
        private string line = "line";

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Returned = Sut.IsEmpty(line);
        }
    }


}