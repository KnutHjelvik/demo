namespace Timpex.Kata._Spec_Advanced.NumberCounter.New.Increment_Act
{
    abstract class IncrementTwice_Act : New_Act
    {
        public int Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            _sut.IncrementNumber();
            _sut.IncrementNumber();
        }

        protected override void Act()
        {
            Returned = _sut.Count;
        }
    }
}