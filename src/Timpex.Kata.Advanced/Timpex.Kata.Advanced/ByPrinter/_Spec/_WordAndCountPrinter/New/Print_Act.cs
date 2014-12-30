namespace Timpex.Kata.Advanced.ByPrinter._Spec._WordAndCountPrinter.New
{
    abstract class Print_Act:New_Act
    {
        protected string Expected = "tim 2";
        protected string Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Returned = Sut.Print(Counter, Word);
        }
    }


}