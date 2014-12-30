using NUnit.Framework;

namespace Timpex.Kata.Advanced.ByPrinter._Spec._WordAndCountPrinter.New
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
        public void It_Should_Print_Word_And_Count()
        {
            Assert.AreEqual(Expected,Returned);
        } 

    }

}