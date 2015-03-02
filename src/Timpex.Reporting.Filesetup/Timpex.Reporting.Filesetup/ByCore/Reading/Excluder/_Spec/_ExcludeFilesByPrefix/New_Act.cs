namespace Timpex.Reporting.Filesetup.ByCore.Reading.Excluder._Spec._ExcludeFilesByPrefix
{
    abstract class New_Act : Base_Act
    {
        protected ExcludeFilesByPrefix Sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new ExcludeFilesByPrefix();
        }
    }


}