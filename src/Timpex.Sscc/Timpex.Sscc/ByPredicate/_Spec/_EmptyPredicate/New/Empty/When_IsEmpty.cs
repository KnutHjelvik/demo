using NUnit.Framework;

namespace Timpex.Sscc.ByPredicate._Spec._EmptyPredicate.New.Empty
{
    [TestFixture]
    class When_IsEmpty:IsEmpty_Act
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