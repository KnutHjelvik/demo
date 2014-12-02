using NUnit.Framework;
using Timpex.Kata.ByAdvancedTimpexPrinter2;

namespace Timpex.Kata._Spec
{
    [TestFixture]
    public class NumberCounterTest
    {
        private Counter _numberCounter = new NumberCounter();

        [Test]
        public void It_Should_increment_value()
        {
            Assert.AreEqual(0, _numberCounter.GetValue());
            _numberCounter.IncrementNumber();
            Assert.AreEqual(1,_numberCounter.GetValue());
            _numberCounter.IncrementNumber();
            Assert.AreEqual(2, _numberCounter.GetValue());
            _numberCounter.IncrementNumber();
            Assert.AreEqual(3, _numberCounter.GetValue()); 
            _numberCounter.IncrementNumber();
            Assert.AreEqual(4, _numberCounter.GetValue());
            _numberCounter.IncrementNumber();
            Assert.AreEqual(5, _numberCounter.GetValue());
        }
    }
}
