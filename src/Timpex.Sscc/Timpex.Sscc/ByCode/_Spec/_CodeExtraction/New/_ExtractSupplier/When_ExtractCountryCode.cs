using NUnit.Framework;
using Timpex.Sscc.ByCode._Spec._CodeExtraction.New._ExtractSerialNumber;

namespace Timpex.Sscc.ByCode._Spec._CodeExtraction.New._ExtractSupplier
{
    [TestFixture]
    class When_ExtractSupplier:ExtractSupplier_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }


        [Test]
        public void It_Should_Extract_Supplier()
        {
            Assert.AreEqual(Returned,Expected);
        }
    }

}