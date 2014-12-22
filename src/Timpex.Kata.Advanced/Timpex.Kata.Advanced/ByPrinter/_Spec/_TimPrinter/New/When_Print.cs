using NUnit.Framework;

namespace Timpex.Kata.Advanced.ByPrinter._Spec._TimPrinter.New
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
        public void It_Should_Return_Tim()
        {
            Assert.AreEqual(Expected,Returned);
        }

    }

}