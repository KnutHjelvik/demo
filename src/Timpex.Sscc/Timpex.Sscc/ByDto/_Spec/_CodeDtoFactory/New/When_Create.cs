using NUnit.Framework;

namespace Timpex.Sscc.ByDto._Spec._CodeDtoFactory.New
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
        public void It_Should_Return_Expected_Instance()
        {
            Assert.AreEqual(Expected,Returned);
        }


        [Test]
        public void It_Should_Be_Same()
        {
            Assert.AreSame(Expected, Returned);
        }


    }

}