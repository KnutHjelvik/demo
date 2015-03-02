namespace Timpex.Reporting.Filesetup.ByCore._Spec._Extensions
{
    abstract class New_Act : Base_Act
    {
        protected AcceptedExtensions Sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new AcceptedExtensions();
        }
    }


}