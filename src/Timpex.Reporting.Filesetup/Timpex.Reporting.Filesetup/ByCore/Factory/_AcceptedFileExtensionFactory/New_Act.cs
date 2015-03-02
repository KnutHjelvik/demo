namespace Timpex.Reporting.Filesetup.ByCore.Factory._AcceptedFileExtensionFactory
{
    abstract class New_Act : Base_Act
    {
        protected AcceptedFileExtensionFactory Sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new AcceptedFileExtensionFactory();
        }
    }


}