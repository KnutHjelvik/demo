using NUnit.Framework;

namespace Timpex.Sscc.ByCode._Spec._CodeExtraction.New._ExtractSerialNumber
{
    [TestFixture]
    class WhenExtractCountryCode:ExtractSerialNumber_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }


        [Test]
        public void It_Should_Extract_SerialNumber()
        {
            Assert.AreEqual(Returned,Expected);
        }
    }

}