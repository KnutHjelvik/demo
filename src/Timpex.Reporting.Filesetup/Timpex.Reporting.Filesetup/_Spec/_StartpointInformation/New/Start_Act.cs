namespace Timpex.Reporting.Filesetup._Spec._StartpointInformation.New
{
    abstract class Start_Act : New_Act
    {
        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut.Start();
        }
    }


}