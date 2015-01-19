using NUnit.Framework;

namespace Timpex.Sscc.ByCode._Spec._ExtractCountryCode.New
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
        public void It_Should_Contain_CountryCode()
        {
            Assert.AreEqual(Returned,Expected);
        }
    }

}