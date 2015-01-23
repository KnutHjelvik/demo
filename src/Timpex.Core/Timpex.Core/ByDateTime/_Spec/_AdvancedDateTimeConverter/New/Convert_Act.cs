using System;

namespace Timpex.Core.ByDateTime._Spec._AdvancedDateTimeConverter.New
{
    abstract class Convert_Act : New_Act
    {
        private DateTime DateAndTime = new DateTime(2015,1,21,11,15,22);
        protected string Expected = "20150121111522";
        protected string Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Returned = Sut.Convert(DateAndTime);
        }
    }


}