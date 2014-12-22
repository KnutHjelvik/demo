using NUnit.Framework;

namespace Timpex.Kata.Advanced.ByPrinter._Spec._TimpexPrinter.New.Pex.PrintOnce
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
        public void It_Should_Print_Pex()
        {
            Assert.AreEqual(Expected,Returned);
        }

    }

}