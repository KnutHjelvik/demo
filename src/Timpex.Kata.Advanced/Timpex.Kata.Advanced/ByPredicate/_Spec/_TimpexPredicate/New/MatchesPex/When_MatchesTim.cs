using NUnit.Framework;
using Timpex.Kata.Advanced.ByPredicate._Spec._TimpexPredicate.New.MatchesTim;

namespace Timpex.Kata.Advanced.ByPredicate._Spec._TimpexPredicate.New.MatchesPex
{
    [TestFixture]
    class When_MatchesTim:MatchesPex_Act
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