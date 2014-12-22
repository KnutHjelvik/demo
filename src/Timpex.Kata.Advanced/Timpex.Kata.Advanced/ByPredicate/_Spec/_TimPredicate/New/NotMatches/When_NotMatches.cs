using NUnit.Framework;
using Timpex.Kata.Advanced.ByPredicate._Spec._TimPredicate.New.Matches;

namespace Timpex.Kata.Advanced.ByPredicate._Spec._TimPredicate.New.NotMatches
{
    [TestFixture]
    class When_NotMatches:NotMatches_Act
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