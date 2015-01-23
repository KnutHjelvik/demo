using NUnit.Framework;

namespace Timpex.Sscc.ByCode._Spec._PresentSSCC.New
{
    [TestFixture]
    class When_PresentCodes:PresentCodes_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Present_Expected_Presentable_Codes()
        {
            Assert.AreEqual(Expected,Returned);
        } 

    }

}