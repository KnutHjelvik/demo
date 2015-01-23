using System;
using Rhino.Mocks;

namespace Timpex.Core.ByDateTime._Spec._DateAndTimeStringConverter.New
{
    abstract class Get_Act : New_Act
    {
        protected DateTime InputDate = new DateTime(2011,11,11,11,11,11);
        protected string Expected = "201111111111";
        protected string Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            TodayGenerator.Stub(x => x.Generate()).Return(InputDate);
            AdvancedDateTimeConverter.Stub(x => x.Convert(InputDate)).Return(Expected);
        }

        protected override void Act()
        {
            Returned = Sut.Get();
        }
    }


}