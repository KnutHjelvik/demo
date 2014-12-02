using System;
using NUnit.Framework;
using Rhino.Mocks;
using Timpex.Kata.ByAdvancedTimpexPrinter2;

namespace Timpex.Kata._Spec
{
    [TestFixture]
    public class CounterPredicateTest
    {
        private CounterPredicate _sut;
        private Counter _counter = MockRepository.GenerateMock<NumberCounter>();

        [Test]
        public void It_Should_Return_True_When_Diviable_with_Three()
        {
            _sut = new CounterPredicate();
            _counter.Stub(x => x.GetValue()).Return(3);
            Boolean _result = _sut.IsDividableWithThree(_counter);
            Assert.AreEqual(true,_result);
        }

        [Test]
        public void It_Should_Return_True_When_Diviable_with_Five()
        {
            _sut = new CounterPredicate();
            _counter.Stub(x => x.GetValue()).Return(5);
            Boolean _result = _sut.IsDividableWithFive(_counter);
            Assert.AreEqual(true, _result);
        }



        [Test]
        public void It_Should_Return_false_When_Not_Diviable_with_Five()
        {
            _sut = new CounterPredicate();
            _counter.Stub(x => x.GetValue()).Return(3);
            Boolean _result = _sut.IsDividableWithFive(_counter);
            Assert.AreEqual(false, _result);
        }

        [Test]
        public void It_Should_Return_false_When_Not_Diviable_with_Three()
        {
            _sut = new CounterPredicate();
            _counter.Stub(x => x.GetValue()).Return(5);
            Boolean _result = _sut.IsDividableWithFive(_counter);
            Assert.AreEqual(false, _result);
        }
    }
}
