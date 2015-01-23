using NUnit.Framework;

namespace Timpex.Sscc.ByCode._Spec._CodeExtraction.New._ExtractCountryCode
{
    [TestFixture]
    class When_ExtractCountryCode:ExtractCountryCode_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }


        [Test]
        public void It_Should_Extract_CountryCode()
        {
            Assert.AreEqual(Returned,Expected);
        }
    }

}