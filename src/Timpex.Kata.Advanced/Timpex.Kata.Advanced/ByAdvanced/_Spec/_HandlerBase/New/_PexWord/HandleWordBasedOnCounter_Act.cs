using Rhino.Mocks;
using Timpex.Kata.Advanced.ByAdvanced._Spec._HandleCounter;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByAdvanced._Spec._HandlerBase.New._PexWord
{
    abstract class HandleWordBasedOnCounter_Act : New_Act
    {
        protected PexWord ExpectedPexWord = MockRepository.GenerateMock<PexWord>();
        protected Word ReturnedPexWord;


        protected override void Arrange()
        {

            base.Arrange();
            base.Act();
            Counter.Stub(x => x.Count).Return(5);
            TimPredicate.Stub(x => x.Matches(Counter)).Return(false);
            PexPredicate.Stub(x => x.Matches(Counter)).Return(true);
            PexWordFactory.Stub(x => x.Create()).Return(ExpectedPexWord);
        }

        protected override void Act()
        {
            ReturnedPexWord = Sut.HandleWordBasedOnCounter(Counter);
        }
    }


}