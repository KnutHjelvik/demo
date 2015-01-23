namespace Timpex.Sscc.ByCode._Spec._SpaceRemover.New
{
    abstract class Remove_Act : New_Act
    {
        protected const string Expected = "123567";
        private const string UnhandledCode = "123 567";
        protected string Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Returned = Sut.Remove(UnhandledCode);
        }
    }


}