using NUnit.Framework;

namespace Timpex.Kata._Spec_Advanced._CounterPredicate.New.NotDividableByThree_Act
{
    [TestFixture]
    class WhenDiviableByThree_Act:NotDividableByThree_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void When_Not_Dividable_By_Three_It_Should_Return_Expected()
        {
            Assert.AreEqual(Expected,Returned);
        }
    }
}