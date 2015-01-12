using Rhino.Mocks;

namespace Timpex.Kata.Advanced.ByWord._Spec._WordConcatenating.New
{
    abstract class Concatinate_Act : New_Act
    {
        protected string Expected = "word1 word2 word3";
        protected string Returned;

        protected TimWord TimWord = MockRepository.GenerateMock<TimWord>();
        protected PexWord PexWord = MockRepository.GenerateMock<PexWord>();
        protected TimpexWord TimpexWord = MockRepository.GenerateMock<TimpexWord>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            TimWord.Stub(x => x.Value()).Return("word1");
            PexWord.Stub(x => x.Value()).Return("word2");
            TimpexWord.Stub(x => x.Value()).Return("word3");
        }

        protected override void Act()
        {
            Returned = Sut.Concatinate(TimWord, PexWord, TimpexWord);
        }
    }


}