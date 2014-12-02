using System;
using NUnit.Framework;
using Rhino.Mocks;
using Timpex.Kata.ByAdvancedTimpexPrinter2;

namespace Timpex.Kata._Spec
{
    [TestFixture]
    public class TimPrinterTest
    {
        private Printer _sut;
        private Counter _numberCounter = MockRepository.GenerateMock<NumberCounter>();
        private CounterPredicate _counterPredicat = MockRepository.GenerateMock<CounterPredicate>();

        [Test]
        public void It_Should_Return_Tim_When_counter_is_1()
        {
            _numberCounter.Stub(x => x.IncrementNumber());
            _numberCounter.Stub(x => x.GetValue()).Return(1);
            _counterPredicat.Stub(x => x.IsDividableWithFive(_numberCounter)).Return(false);
            _counterPredicat.Stub(x => x.IsDividableWithThree(_numberCounter)).Return(false);
            _sut = new TimPrinter(_numberCounter, _counterPredicat);
            String _result = _sut.Print();
            _numberCounter.AssertWasCalled(x => x.IncrementNumber());
            Assert.AreEqual(_result, "tim");
        }

        [Test]
        public void It_Should_Return_Tim_Counter()
        {
            _numberCounter.Stub(x => x.IncrementNumber());
            _numberCounter.Stub(x => x.GetValue()).Return(2);
            _counterPredicat.Stub(x => x.IsDividableWithFive(_numberCounter)).Return(false);
            _counterPredicat.Stub(x => x.IsDividableWithThree(_numberCounter)).Return(false);
            _sut = new TimPrinter(_numberCounter, _counterPredicat);
            String _result = _sut.Print();
            _numberCounter.AssertWasCalled(x => x.IncrementNumber());
            Assert.AreEqual(_result, "tim2");
        }
        
        [Test]
        public void It_Should_Return_Tim_Tim_When_Counter_Is_Dividable_With_Three()
        {
            _numberCounter.Stub(x => x.IncrementNumber());
            _numberCounter.Stub(x => x.GetValue()).Return(6);
            _counterPredicat.Stub(x => x.IsDividableWithFive(_numberCounter)).Return(false);
            _counterPredicat.Stub(x => x.IsDividableWithThree(_numberCounter)).Return(true);
            _sut = new TimPrinter(_numberCounter, _counterPredicat);
            String _result = _sut.Print();
            _numberCounter.AssertWasCalled(x => x.IncrementNumber());
            Assert.AreEqual(_result, "tim tim");
        }
        [Test]
        public void It_Should_Return_Tim_Pex_When_Counter_Is_Dividable_With_Five()
        {
            _numberCounter.Stub(x => x.IncrementNumber());
            _numberCounter.Stub(x => x.GetValue()).Return(5);
            _counterPredicat.Stub(x => x.IsDividableWithFive(_numberCounter)).Return(true);
            _counterPredicat.Stub(x => x.IsDividableWithThree(_numberCounter)).Return(false);
            _sut = new TimPrinter(_numberCounter, _counterPredicat);
            String _result = _sut.Print();
            _numberCounter.AssertWasCalled(x => x.IncrementNumber());
            Assert.AreEqual(_result, "tim pex");
        }
         [Test]
        public void It_Should_Return_Tim_Timpex_When_Counter_Is_Dividable_With_Five_and_Three()
        {
            _numberCounter.Stub(x => x.IncrementNumber());
            _numberCounter.Stub(x => x.GetValue()).Return(5);
            _counterPredicat.Stub(x => x.IsDividableWithFive(_numberCounter)).Return(true);
            _counterPredicat.Stub(x => x.IsDividableWithThree(_numberCounter)).Return(true);
            _sut = new TimPrinter(_numberCounter, _counterPredicat);
            String _result = _sut.Print();
            _numberCounter.AssertWasCalled(x => x.IncrementNumber());
            Assert.AreEqual(_result, "tim timpex");
        }
    }
}
