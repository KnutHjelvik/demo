using NUnit.Framework;

namespace Timpex.Kata._Spec_Advanced._CounterPredicate.New.DividableByThree_Act
{
    [TestFixture]
    class WhenDiviableByThree_Act:DividableByThree_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void When_Dividable_By_Three_It_Should_Return_Expected()
        {
            Assert.AreEqual(Expected,Returned);
        }
    }
}