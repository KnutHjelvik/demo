using NUnit.Framework;

namespace Timpex.Kata._Spec_Advanced._CounterPredicate.New.DividableByFive_Act
{
    [TestFixture]
    class WhenDiviableByFive_Act:DividableByFive_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void When_Dividable_By_Five_It_Should_Return_Expected()
        {
            Assert.AreEqual(Expected,Returned);
        }
    }
}