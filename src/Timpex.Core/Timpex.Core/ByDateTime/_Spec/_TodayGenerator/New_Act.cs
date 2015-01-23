namespace Timpex.Core.ByDateTime._Spec._TodayGenerator
{
    abstract class New_Act : Base_Act
    {
        protected TodayGenerator Sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new TodayGenerator();
        }
    }


}