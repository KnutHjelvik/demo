using NUnit.Framework;

namespace Timpex.Core.ByDateTime._Spec._TodayGenerator.New
{
    [TestFixture]
    class When_Generate:Generate_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }


        [Test]
        public void It_Should_Return_Expected_Date()
        {
            Assert.AreEqual(Expected,Returned);
        }

    }

}