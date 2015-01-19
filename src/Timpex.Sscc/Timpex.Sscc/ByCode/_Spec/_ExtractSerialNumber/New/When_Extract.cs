using NUnit.Framework;

namespace Timpex.Sscc.ByCode._Spec._ExtractSerialNumber.New
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
        public void It_Should_Contain_Expected_SerialNumber()
        {
            Assert.AreEqual(Returned,Expected);
        }
    }

}