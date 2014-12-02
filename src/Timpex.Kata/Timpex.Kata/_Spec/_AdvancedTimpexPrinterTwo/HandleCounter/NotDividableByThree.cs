using System;
using NUnit.Framework;
using Rhino.Mocks;
using Timpex.Kata.ByAdvancedTimpexPrinter2;

namespace Timpex.Kata._Spec._AdvancedTimpexPrinterTwo.HandleCounter
{
    [TestFixture]
    class NotDividableByFive
    {

        private CounterPredicate _sut = new CounterPredicate();

        private NumberCounter _counter = MockRepository.GenerateMock<NumberCounter>();
        private const Boolean _dividableWithThree = false;

        [TestFixtureSetUp]
        public void Arrange()
        {
            _counter.Stub(x => x.GetValue()).Return(7);
        }

        [Test]
        public void It_Should_return_false_when_dividing_with_three()
        {
            Boolean result = _sut.IsDividableWithFive(_counter);
            Assert.AreEqual(result, _dividableWithThree);
        }
    }
}
