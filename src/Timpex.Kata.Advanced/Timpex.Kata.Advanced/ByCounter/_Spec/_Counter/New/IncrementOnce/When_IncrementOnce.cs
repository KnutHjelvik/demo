using NUnit.Framework;

namespace Timpex.Kata.Advanced.ByCounter._Spec._Counter.New.IncrementOnce
{
    [TestFixture]
    class When_IncrementOnce:IncrementOnce_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }


        [Test]
        public void It_Should_Return_One()
        {
            Assert.AreEqual(1,Sut.Count);
        }

    }

}