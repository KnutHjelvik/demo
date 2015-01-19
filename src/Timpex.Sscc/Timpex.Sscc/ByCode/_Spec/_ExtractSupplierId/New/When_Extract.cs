using NUnit.Framework;

namespace Timpex.Sscc.ByCode._Spec._ExtractSupplierId.New
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
        public void It_Should_Contain_Expected_SupplierID()
        {
            Assert.AreEqual(Returned,Expected);
        }
    }

}