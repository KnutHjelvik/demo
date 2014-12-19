using NUnit.Framework;

namespace Timpex.Kata._Spec_Advanced._CounterPredicate.New.NotDividableByFive_Act
{
    [TestFixture]
    class WhenNotDiviableByFive_Act:NotDividableByFive_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void When_Not_Dividable_By_Five_It_Should_Return_Expected()
        {
            Assert.AreEqual(Expected,Returned);
        }
    }
}