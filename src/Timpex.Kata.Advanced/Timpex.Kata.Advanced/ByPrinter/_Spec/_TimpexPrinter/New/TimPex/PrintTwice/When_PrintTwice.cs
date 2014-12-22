using NUnit.Framework;
using Timpex.Kata.Advanced.ByPrinter._Spec._TimpexPrinter.New.Pex.PrintOnce;

namespace Timpex.Kata.Advanced.ByPrinter._Spec._TimpexPrinter.New.TimPex.PrintTwice
{
    [TestFixture]
    class When_PrintTwice:PrintTwice_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }


        [Test]
        public void It_Should_Print_Timpex2()
        {
            Assert.AreEqual(Expected,Returned);
        }

    }

}