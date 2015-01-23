namespace Timpex.Core.ByDateTime._Spec._AdvancedDateTimeConverter
{
    abstract class New_Act : Base_Act
    {
        protected AdvancedDateTimeConverter Sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new AdvancedDateTimeConverter();
        }
    }


}