using NUnit.Framework;

namespace Timpex.Kata.Advanced.ByPrinter._Spec._WordPrinter.New.PrintTwice
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