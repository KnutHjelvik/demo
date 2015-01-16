using NUnit.Framework;

namespace Timpex.Sscc.ByCode._Spec._CodeListFactory.New
{
    [TestFixture]
    class When_CreateCodeList:CreateCodeList_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Return_List_Of_Expected_Codes()
        {
            Assert.AreEqual(Returned,Expected);
        }


    }


}