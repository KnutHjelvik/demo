using System;

namespace Timpex.Core.ByDateTime._Spec._TodayGenerator.New
{
    abstract class Generate_Act : New_Act
    {
        protected DateTime Expected = DateTime.Today;
        protected DateTime Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Returned = Sut.Generate();
        }
    }


}