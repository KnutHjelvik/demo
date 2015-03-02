namespace Timpex.Reporting.Filesetup.ByCore._Spec._Extensions.New
{
    abstract class SetAcceptedExtensions_Act : New_Act
    {
        
        protected static string Bat = ".bat";
        protected static string Dtsx = ".dtsx";
        protected string[] Expected = { Bat, Dtsx };

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut.init(".bat",".dtsx");
        }
    }


}