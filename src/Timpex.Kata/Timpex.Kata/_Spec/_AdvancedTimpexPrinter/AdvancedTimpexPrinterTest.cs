using NUnit.Framework;
using Timpex.Kata.AdvancedTimpexPrinter;

namespace Timpex.Kata._Spec._AdvancedTimpexPrinter
{  
    [TestFixture]
    class AdvancedTimpexPrinterTest
    {
        

        private TimpexAdvancedPrinter _advancedTimpexPrinter = new TimpexAdvancedPrinter();


        [Test]
        public void It_Should_Return_Expected()
        {
            Assert.AreEqual("1",_advancedTimpexPrinter.Print());
            Assert.AreEqual("2",_advancedTimpexPrinter.Print());
            Assert.AreEqual("tim",_advancedTimpexPrinter.Print());
            Assert.AreEqual("4",_advancedTimpexPrinter.Print());
            Assert.AreEqual("pex",_advancedTimpexPrinter.Print());
            Assert.AreEqual("tim 2",_advancedTimpexPrinter.Print());
            Assert.AreEqual("7",_advancedTimpexPrinter.Print());
            Assert.AreEqual("8",_advancedTimpexPrinter.Print());
            Assert.AreEqual("tim tim",_advancedTimpexPrinter.Print());
            Assert.AreEqual("pex 2",_advancedTimpexPrinter.Print());
            Assert.AreEqual("11",_advancedTimpexPrinter.Print());
            Assert.AreEqual("tim 4",_advancedTimpexPrinter.Print());
            Assert.AreEqual("13",_advancedTimpexPrinter.Print());
            Assert.AreEqual("14",_advancedTimpexPrinter.Print());
            Assert.AreEqual("timpex",_advancedTimpexPrinter.Print());
            Assert.AreEqual("16",_advancedTimpexPrinter.Print());
            Assert.AreEqual("17",_advancedTimpexPrinter.Print());
            Assert.AreEqual("tim pex",_advancedTimpexPrinter.Print());
            Assert.AreEqual("19",_advancedTimpexPrinter.Print());
            Assert.AreEqual("pex tim", _advancedTimpexPrinter.Print());
            Assert.AreEqual("tim tim", _advancedTimpexPrinter.Print());
            Assert.AreEqual("22", _advancedTimpexPrinter.Print());
            Assert.AreEqual("23", _advancedTimpexPrinter.Print());
            Assert.AreEqual("tim 7", _advancedTimpexPrinter.Print());
            Assert.AreEqual("pex 4", _advancedTimpexPrinter.Print());
            Assert.AreEqual("26", _advancedTimpexPrinter.Print());
            Assert.AreEqual("tim 8", _advancedTimpexPrinter.Print());
            Assert.AreEqual("28", _advancedTimpexPrinter.Print());
            Assert.AreEqual("29", _advancedTimpexPrinter.Print());
            Assert.AreEqual("timpex 2", _advancedTimpexPrinter.Print());
            Assert.AreEqual("31", _advancedTimpexPrinter.Print());
            Assert.AreEqual("32", _advancedTimpexPrinter.Print());
            Assert.AreEqual("tim tim", _advancedTimpexPrinter.Print());
            Assert.AreEqual("34", _advancedTimpexPrinter.Print());
            Assert.AreEqual("pex pex", _advancedTimpexPrinter.Print());
        }
    }
}
