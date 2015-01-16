using NUnit.Framework;

namespace Timpex.Sscc.ByPredicate._Spec._LengthOfCodePredicate.New.Matches
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
        public void It_Should_Return_true()
        {
            Assert.AreEqual(Expected,Returned);
        }

    }

}