namespace Timpex.Sscc.ByIO._Spec._FileExtension
{
    abstract class New_Act : Base_Act
    {

        protected FileExtension Sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new FileExtension();
        }
    }


}   