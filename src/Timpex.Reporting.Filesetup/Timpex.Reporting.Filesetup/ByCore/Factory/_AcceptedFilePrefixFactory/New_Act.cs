namespace Timpex.Reporting.Filesetup.ByCore.Factory._AcceptedFilePrefixFactory
{
    abstract class New_Act : Base_Act
    {
        protected AcceptedFilePrefixFactory Sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new AcceptedFilePrefixFactory();
        }
    }


}