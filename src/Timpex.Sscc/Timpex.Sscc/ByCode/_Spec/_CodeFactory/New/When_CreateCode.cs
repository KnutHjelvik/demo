using NUnit.Framework;
using Rhino.Mocks;

namespace Timpex.Sscc.ByCode._Spec._CodeFactory.New
{
    [TestFixture]
    class When_CreateCode:CreateCode_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Setup_Instance()
        {
            ExpectedInstance.AssertWasCalled(x=> x.Setup(code));
        }

        [Test]
        public void It_Should_Return_Instance()
        {
            Assert.AreSame(ExpectedInstance,RetunrnedInstance);
        }

    }



}