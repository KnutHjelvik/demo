using NUnit.Framework;

namespace Timpex.Sscc.ByDto._Spec._DtoPresentator.New
{
    [TestFixture]
    class When_Present:Present_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Return_Expected_List_Of_Presentable_Codes()
        {
            Assert.AreEqual(Returned,Expected);
        } 

    }

}