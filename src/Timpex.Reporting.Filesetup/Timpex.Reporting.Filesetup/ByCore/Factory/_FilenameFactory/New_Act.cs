namespace Timpex.Reporting.Filesetup.ByCore.Factory._FilenameFactory
{
    abstract class New_Act : Base_Act
    {
        protected FilenameFactory Sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new FilenameFactory();
        }
    }


}