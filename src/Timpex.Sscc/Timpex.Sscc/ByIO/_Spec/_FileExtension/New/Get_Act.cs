namespace Timpex.Sscc.ByIO._Spec._FileExtension.New
{
    abstract class Get_Act : New_Act
    {
        protected string Expected = ".txt";
        protected string Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Returned = Sut.Get();
        }
    }


}