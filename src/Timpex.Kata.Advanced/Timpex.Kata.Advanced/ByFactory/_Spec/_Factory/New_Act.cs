using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByFactory._Spec._Factory
{
    abstract class New_Act : Base_Act
    {
        protected Factory<TimWord> Sut; 

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new Factory<TimWord>();
        }
    }


}