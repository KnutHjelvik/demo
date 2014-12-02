using System;
using NUnit.Framework;
using Rhino.Mocks;
using Timpex.Kata.ByAdvancedTimpexPrinter2;

namespace Timpex.Kata._Spec
{
    [TestFixture]
    class AdvancedTimpexPrinterTwoTest
    {

        private Counter _numberCounter = MockRepository.GenerateMock<NumberCounter>();
        private CounterPredicate _counterPredicateHandler = MockRepository.GenerateMock<CounterPredicate>();
        private Printer _timPrinter = MockRepository.GenerateMock<TimPrinter>();
        private Printer _pexPrinter = MockRepository.GenerateMock<PexPrinter>();
        private Printer _timpexPrinter = MockRepository.GenerateMock<TimpexPrinter>();
        private readonly Random _random = new Random();
        private int _currentIndex ;
        private AdvancedTimpexPrinterTwo _sut ;

        private String _result="";
        

        [Test]
        public void When_Not_Dividable_By_Five_Or_Three()
        {
            _sut = new AdvancedTimpexPrinterTwo(_timpexPrinter, _timPrinter, _pexPrinter, _counterPredicateHandler, _numberCounter);
            _currentIndex = _random.Next(1, 2000);
            _numberCounter.Stub(x => x.IncrementNumber());
            _numberCounter.Stub(x => x.GetValue()).Return(_currentIndex);
            _counterPredicateHandler.Stub(x => x.IsDividableWithFive(_numberCounter)).Return(false);
            _counterPredicateHandler.Stub(x => x.IsDividableWithThree(_numberCounter)).Return(false);
            _result = _sut.Print();
            _numberCounter.AssertWasCalled(x => x.IncrementNumber());
            Assert.AreEqual(_currentIndex.ToString(),_result);
        }

        [Test]
        public void When_Dividable_By_Five_Or_Three()
        {
            _sut = new AdvancedTimpexPrinterTwo(_timpexPrinter, _timPrinter, _pexPrinter, _counterPredicateHandler, _numberCounter);
            _currentIndex = 15;
            _numberCounter.Stub(x => x.IncrementNumber());
            _numberCounter.Stub(x => x.GetValue()).Return(_currentIndex);
            _counterPredicateHandler.Stub(x => x.IsDividableWithFive(_numberCounter)).Return(true);
            _counterPredicateHandler.Stub(x => x.IsDividableWithThree(_numberCounter)).Return(true);
            _timpexPrinter.Stub(x => x.Print()).Return(_currentIndex.ToString());
            _result = _sut.Print();
            _numberCounter.AssertWasCalled(x => x.IncrementNumber());
            Assert.AreEqual(_currentIndex.ToString(), _result);
        }

        [Test]
        public void When_Dividable_By_Three_And_Not_Five()
        {
            _sut = new AdvancedTimpexPrinterTwo(_timpexPrinter, _timPrinter, _pexPrinter, _counterPredicateHandler, _numberCounter);
            _currentIndex = 6;
            _numberCounter.Stub(x => x.IncrementNumber());
            _numberCounter.Stub(x => x.GetValue()).Return(_currentIndex);
            _counterPredicateHandler.Stub(x => x.IsDividableWithFive(_numberCounter)).Return(false);
            _counterPredicateHandler.Stub(x => x.IsDividableWithThree(_numberCounter)).Return(true);
            _timPrinter.Stub(x => x.Print()).Return(_currentIndex.ToString());
            _result = _sut.Print();
            _numberCounter.AssertWasCalled(x => x.IncrementNumber());
            Assert.AreEqual(_currentIndex.ToString(), _result);
        }


        [Test]
        public void When_Dividable_By_Five_And_Not_Three()
        {
            _currentIndex = 5;
            _numberCounter.Stub(x => x.IncrementNumber());
            _numberCounter.Stub(x => x.GetValue()).Return(_currentIndex);
            _counterPredicateHandler.Stub(x => x.IsDividableWithFive(_numberCounter)).Return(true);
            _counterPredicateHandler.Stub(x => x.IsDividableWithThree(_numberCounter)).Return(false);
            _pexPrinter.Stub(x => x.Print()).Return(_currentIndex.ToString());
            _sut = new AdvancedTimpexPrinterTwo(_timpexPrinter, _timPrinter, _pexPrinter, _counterPredicateHandler, _numberCounter);
            _result = _sut.Print();
            _numberCounter.AssertWasCalled(x => x.IncrementNumber());
            Assert.AreEqual(_currentIndex.ToString(), _result);
        }


    }
}
