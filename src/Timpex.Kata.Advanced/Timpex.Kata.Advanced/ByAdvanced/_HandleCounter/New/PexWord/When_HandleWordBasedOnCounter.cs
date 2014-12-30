using NUnit.Framework;

namespace Timpex.Kata.Advanced.ByAdvanced._HandleCounter.New.PexWord
{
    [TestFixture]
    class When_HandleWordBasedOnCounter:HandleWordBasedOnCounter_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }


        [Test]
        public void It_Should_Return_Pex_Word()
        {
            Assert.AreEqual(Expected,Returned.Value());
        }

    }

}