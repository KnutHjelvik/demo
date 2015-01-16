using NUnit.Framework;

namespace Timpex.Sscc.ByCode._Spec._Code.New
{
    [TestFixture]
    class When_Value:Value_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Return_Expected()
        {
            Assert.AreEqual(Expected,Returned);
        } 

    }

}