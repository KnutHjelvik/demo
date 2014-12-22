using NUnit.Framework;

namespace Timpex.Kata.Advanced.ByPredicate._Spec._TimpexPredicate.New.MatchesTim
{
    [TestFixture]
    class When_MatchesTim:MatchesTim_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Return_False()
        {
            Assert.AreEqual(Expected,Returned);
        }

        
 

    }

}