using System;
using NUnit.Framework;
using Rhino.Mocks;
using Timpex.Kata.ByAdvancedTimpexPrinter2;

namespace Timpex.Kata._Spec._AdvancedTimpexPrinterTwo.HandleCounter
{
    [TestFixture]
    class DividableByFive
    {

        private CounterPredicate _sut = new CounterPredicate();

        private NumberCounter _counter = MockRepository.GenerateMock<NumberCounter>();
        private const Boolean _dividableWithFive = true;

        [TestFixtureSetUp]
        public void Arrange()
        {
            _counter.Stub(x => x.GetValue()).Return(5);
        }

        [Test]
        public void It_Should_return_false_when_dividing_with_five()
        {
            Boolean result = _sut.IsDividableWithFive(_counter);
            Assert.AreEqual(_dividableWithFive, result);
        }
    }
}
