using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhino.Mocks;
using Timpex.Kata.ByAdvancedTimpexPrinter2;

namespace Timpex.Kata._Spec_Advanced._PexPrinter
{
    abstract class New_Act : Base_Act
    {
        protected Counter Counter = MockRepository.GenerateMock<Counter>();
        protected CounterPredicate CounterPredicate = MockRepository.GenerateMock<CounterPredicate>();
        protected Printer Sut;
        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new PexPrinter(Counter,CounterPredicate);
        }
    }


}
