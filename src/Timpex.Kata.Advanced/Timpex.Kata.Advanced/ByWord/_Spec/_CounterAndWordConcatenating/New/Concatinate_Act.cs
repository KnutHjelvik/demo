using Rhino.Mocks;

namespace Timpex.Kata.Advanced.ByWord._Spec._CounterAndWordConcatenating.New
{
    abstract class Concatinate_Act : New_Act
    {
        protected string Expected = "tim 3";
        protected string Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Counter.Stub(x => x.Count).Return(3);
            Word.Stub(x => x.Value()).Return("tim");
        }

        protected override void Act()
        {
            Returned = Sut.Concatinate(Counter, Word);
        }
    }


}