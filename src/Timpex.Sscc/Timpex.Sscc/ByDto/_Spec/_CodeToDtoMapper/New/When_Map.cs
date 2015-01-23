using NUnit.Framework;
using Rhino.Mocks;

namespace Timpex.Sscc.ByDto._Spec._CodeToDtoMapper.New
{
    [TestFixture]
    class When_Map:Map_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Setup_Instance()
        {
            CodeExtracter.AssertWasCalled(x=>x.Setup(UnhandledCode));
        }

        [Test]
        public void It_Should_Contain_Country_Code()
        {
            Assert.AreEqual(CountryCode, Returned.CountryCode);
        }

        [Test]
        public void It_Should_Contain_Serial_Code()
        {
            Assert.AreEqual(SerialNumber,Returned.Serial);
        }

        [Test]
        public void It_Should_Contain_Supplier_Code()
        {
            Assert.AreEqual(Supplier,Returned.SupplierCode);
        }

        [Test]
        public void It_Should_Contain_Identifier_Code()
        {
            Assert.AreEqual(Identifier, Returned.Identifier);
        }

        [Test]
        public void It_Should_Contain_ApplicationIdentifer_Code()
        {
            Assert.AreEqual(ApplicationIdentifier, Returned.ApplicationIdentifier);
        }

    }

}