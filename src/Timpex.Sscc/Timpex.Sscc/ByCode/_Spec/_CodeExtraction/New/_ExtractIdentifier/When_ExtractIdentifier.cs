using NUnit.Framework;
using Timpex.Sscc.ByCode._Spec._CodeExtraction.New._ExtractSerialNumber;

namespace Timpex.Sscc.ByCode._Spec._CodeExtraction.New._ExtractIdentifier
{
    [TestFixture]
    class When_ExtractIdentifier:ExtractIdentifier_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }


        [Test]
        public void It_Should_Extract_Identifier()
        {
            Assert.AreEqual(Returned,Expected);
        }
    }

}