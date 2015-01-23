using NUnit.Framework;

namespace Timpex.Sscc.ByDto._Spec._CodeDtoStringCreater.New
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
        public void It_Should_Create_Expected_String()
        {
            Assert.AreEqual(Expected,Returned);
        }

    }

}