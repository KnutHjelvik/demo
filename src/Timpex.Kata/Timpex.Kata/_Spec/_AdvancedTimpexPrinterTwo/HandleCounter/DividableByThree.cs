using System;
using NUnit.Framework;
using Rhino.Mocks;
using Timpex.Kata.ByAdvancedTimpexPrinter2;

namespace Timpex.Kata._Spec._AdvancedTimpexPrinterTwo.HandleCounter
{
    [TestFixture]
    class DividableByThree
    {

        private CounterPredicate _sut = new CounterPredicate();

        private NumberCounter _counter = MockRepository.GenerateMock<NumberCounter>();
        private const Boolean _dividableWithThree = true;

        [TestFixtureSetUp]
        public void Arrange()
        {
            _counter.Stub(x => x.GetValue()).Return(6);
        }

        [Test]
        public void It_Should_return_true_when_dividing_with_five()
        {
            Boolean result = _sut.IsDividableWithThree(_counter);
            Assert.AreEqual(_dividableWithThree, result);
        }
    }
}
