namespace Timpex.Core.ByStrings._Spec._Strings
{
    abstract class New_Act : Base_Act
    {
        protected Strings Sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new Strings();
        }
    }


}