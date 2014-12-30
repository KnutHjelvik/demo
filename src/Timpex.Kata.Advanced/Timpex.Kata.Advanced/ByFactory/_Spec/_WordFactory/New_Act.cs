using Rhino.Mocks;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByFactory._Spec._WordFactory
{
    abstract class New_Act : Base_Act
    {
        protected WordFactory<TimWord> Sut;
        protected Factory<TimWord> Factory = MockRepository.GenerateMock<Factory<TimWord>>();
        

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new WordFactory<TimWord>(Factory);
        }
    }


}