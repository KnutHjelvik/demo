using NUnit.Framework;

namespace Timpex.Kata.Advanced.ByCounter._Spec._Counter.New.IncrementTwice
{
    [TestFixture]
    class When_IncrementTwice:IncrementTwice_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }


        [Test]
        public void It_Should_Return_Two()
        {
            Assert.AreEqual(2,Sut.Count);
        }

    }

}