using NUnit.Framework;

namespace Timpex.Kata._Spec._TimpexPrinter
{
    [TestFixture]
    public class TimpexPrinterTest
    {
        private readonly TimpexPrinter _printer = new TimpexPrinter();        
        
        [TestFixtureSetUp]
        public void When_Printing()
        {            
        }

        [Test]
        public void It_Should_Return_Expected()
        {
            Assert.AreEqual("1", _printer.Print());
            Assert.AreEqual("2", _printer.Print());
            Assert.AreEqual("tim", _printer.Print());
            Assert.AreEqual("4", _printer.Print());
            Assert.AreEqual("pex", _printer.Print());
            Assert.AreEqual("tim", _printer.Print());
            Assert.AreEqual("7", _printer.Print());
            Assert.AreEqual("8", _printer.Print());
            Assert.AreEqual("tim", _printer.Print());
            Assert.AreEqual("pex", _printer.Print());
            Assert.AreEqual("11", _printer.Print());
            Assert.AreEqual("tim", _printer.Print());
            Assert.AreEqual("13", _printer.Print());
            Assert.AreEqual("14", _printer.Print());
            Assert.AreEqual("timpex", _printer.Print());
        }
    }
}
