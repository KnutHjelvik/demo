using NUnit.Framework;

namespace Timpex.Kata.Advanced.ByAdvanced._Spec._AdvancedWordPrinter.New.ActualWord_AndAdditionalWord
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
        public void It_Should_Print_Actual_Word_And_Pex()
        {
            Assert.AreEqual(Expected,Returned);
        } 

    }

}