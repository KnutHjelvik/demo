using NUnit.Framework;
using Timpex.Kata.Advanced.ByPrinter._Spec._TimpexPrinter.New.Tim.PrintOnce;

namespace Timpex.Kata.Advanced.ByPrinter._Spec._TimpexPrinter.New.Tim.PrintTwice
{
    [TestFixture]
    class When_PrintTwice:PrintOnce_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }


        [Test]
        public void It_Should_Print_Tim2()
        {
            Assert.AreEqual(Expected,Returned);
        }

    }

}