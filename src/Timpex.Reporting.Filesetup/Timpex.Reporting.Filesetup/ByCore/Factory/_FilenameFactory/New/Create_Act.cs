namespace Timpex.Reporting.Filesetup.ByCore.Factory._FilenameFactory.New
{
    abstract class Create_Act : New_Act
    {
        protected string FQPath = "C:/foldername/test.txt";
        protected string Expected = "test.txt";
        protected string Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Returned = Sut.Create(FQPath);
        }
    }


}