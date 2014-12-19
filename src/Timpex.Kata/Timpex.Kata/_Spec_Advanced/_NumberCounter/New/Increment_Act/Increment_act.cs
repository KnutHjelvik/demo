using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timpex.Kata._Spec_Advanced.NumberCounter.New.Increment_Act
{
    abstract class Increment_Act:New_Act
    {
        public int Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            _sut.IncrementNumber();
            Returned = _sut.Count;
        }
    }
}
