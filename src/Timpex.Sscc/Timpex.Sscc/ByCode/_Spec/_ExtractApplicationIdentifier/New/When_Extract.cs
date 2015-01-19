using NUnit.Framework;
using Rhino.Mocks.Constraints;

namespace Timpex.Sscc.ByCode._Spec._ExtractApplicationIdentifier.New
{
    [TestFixture]
    class When_Extract:Extract_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }


        [Test]
        public void It_Should_Contain_ApplicationIdentifier()
        {
            Assert.AreEqual(Returned,Expected);
        }

        [Test]
        public void It_Should_Contain_Parenthesis()
        {
            Assert.IsTrue(Returned.Contains("(") && Returned.Contains(")"));
        }

    }

}