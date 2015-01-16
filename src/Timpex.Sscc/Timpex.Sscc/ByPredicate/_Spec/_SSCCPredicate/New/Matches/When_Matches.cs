using NUnit.Framework;

namespace Timpex.Sscc.ByPredicate._Spec._SSCCPredicate.New.Matches
{
    [TestFixture]
    class When_Matches:Matches_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Return_True()
        {
            Assert.AreEqual(Expected,Returned);
        } 

    }

}