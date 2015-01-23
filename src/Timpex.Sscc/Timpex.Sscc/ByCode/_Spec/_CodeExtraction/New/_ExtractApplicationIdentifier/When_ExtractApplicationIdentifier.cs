using NUnit.Framework;

namespace Timpex.Sscc.ByCode._Spec._CodeExtraction.New._ExtractApplicationIdentifier
{
    [TestFixture]
    class When_ExtractApplicationIdentifier:ExtractApplicationIdentifier_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }


        [Test]
        public void It_Should_Extract_ApplicationIdeitifier()
        {
            Assert.AreEqual(Returned,Expected);
        }
    }

}