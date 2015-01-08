using NUnit.Framework;

namespace Timpex.Kata.Advanced.ByAdvanced._Spec._PexWordFactory.New
{
    [TestFixture]
    class When_Create:Create_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Create_TimpexWord()
        {
            Assert.IsInstanceOf(Expected,Returned);
        } 

    }

}