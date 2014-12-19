using NUnit.Framework;

namespace Timpex.Kata._Spec_Advanced._PexPrinter.New.PrintPexCount
{
    [TestFixture]
    class When_Print: PrintPexTimpex.Print_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Print_Pex_Counts()
        {
            Assert.AreEqual(Expected,Returned);
        }

    }

}