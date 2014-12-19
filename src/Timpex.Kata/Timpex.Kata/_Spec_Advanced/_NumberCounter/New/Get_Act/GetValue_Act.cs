namespace Timpex.Kata._Spec_Advanced.NumberCounter.New.Get_Act
{
    abstract class GetValue_Act:New_Act
    {
        protected int expected = 5;
        protected int returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            _sut.Count = 5;
        }

        protected override void Act()
        {
            returned = _sut.GetValue();
        }
    }
}
