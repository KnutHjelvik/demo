using Rhino.Mocks;

namespace Timpex.Kata.Advanced.ByPrinter._Spec._SimpleWordPrinter.New
{
    abstract class Print_Act:New_Act
    {
        protected string Expected = "tim pex";
        protected string Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            WordConcatenating.Stub(x => x.Concatinate(Word1, Word2)).Return(Expected);
        }

        protected override void Act()
        {
            Returned = Sut.Print(Word1, Word2);
        }
    }


}