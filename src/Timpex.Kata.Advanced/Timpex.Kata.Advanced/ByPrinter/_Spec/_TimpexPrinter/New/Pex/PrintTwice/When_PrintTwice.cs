using NUnit.Framework;

namespace Timpex.Kata.Advanced.ByPrinter._Spec._TimpexPrinter.New.Pex.PrintTwice
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
        public void It_Should_Print_Pex2()
        {
            Assert.AreEqual(Expected,Returned);
        }

    }

}