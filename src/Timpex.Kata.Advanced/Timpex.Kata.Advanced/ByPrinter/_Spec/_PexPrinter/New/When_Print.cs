using NUnit.Framework;

namespace Timpex.Kata.Advanced.ByPrinter._Spec._PexPrinter.New
{

    [TestFixture]
    class When_Print:Print_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }


        [Test]
        public void It_Should_Return_Pex()
        {
            Assert.AreEqual(Expected,Returned);
        }

    }

}