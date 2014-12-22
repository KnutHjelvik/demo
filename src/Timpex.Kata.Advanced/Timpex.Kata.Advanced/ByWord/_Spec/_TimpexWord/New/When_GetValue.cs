using NUnit.Framework;

namespace Timpex.Kata.Advanced.ByWord._Spec._TimpexWord.New
{
    [TestFixture]
    class When_GetValue:GetValue_Act
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
            Assert.AreEqual(Expected,Result);
        }

    }

}