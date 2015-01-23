namespace Timpex.Sscc.ByIO._Spec._FilePrefix
{
    abstract class New_Act : Base_Act
    {

        protected FilePrefix Sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new FilePrefix();
        }
    }


}   