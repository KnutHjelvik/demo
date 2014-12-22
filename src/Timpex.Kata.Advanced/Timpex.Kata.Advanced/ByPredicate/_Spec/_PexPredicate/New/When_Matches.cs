using NUnit.Framework;

namespace Timpex.Kata.Advanced.ByPredicate._Spec._PexPredicate.New
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