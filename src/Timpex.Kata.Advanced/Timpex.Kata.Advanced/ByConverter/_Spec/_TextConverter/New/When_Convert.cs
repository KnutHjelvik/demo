using NUnit.Framework;

namespace Timpex.Kata.Advanced.ByConverter._Spec._TextConverter.New
{
    [TestFixture]
    class When_Convert:Convert_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }


        [Test]
        public void It_Should_Return_A_String()
        {
            Assert.AreEqual(Expected,Returned);
        }

    }

}