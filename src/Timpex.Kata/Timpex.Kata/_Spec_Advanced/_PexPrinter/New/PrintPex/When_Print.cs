using NUnit.Framework;

namespace Timpex.Kata._Spec_Advanced._PexPrinter.New.PrintPex
{
    [TestFixture]
    class When_Print: Print_Act
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