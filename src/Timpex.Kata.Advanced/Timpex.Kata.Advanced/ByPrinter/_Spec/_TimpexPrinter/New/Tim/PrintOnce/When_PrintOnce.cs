using NUnit.Framework;

namespace Timpex.Kata.Advanced.ByPrinter._Spec._TimpexPrinter.New.Tim.PrintOnce
{
    [TestFixture]
    class When_PrintOnce:PrintOnce_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }


        [Test]
        public void It_Should_Print_Tim()
        {
            Assert.AreEqual(Expected,Returned);
        }

    }

}