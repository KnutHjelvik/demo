using NUnit.Framework;

namespace Timpex.Reporting.Filesetup.ByCore.Reading._Spec._FileReader.New
{

    [TestFixture]
    class When_Read:Read_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Read_And_Return_Expected_List()
        {
            Assert.AreEqual(Expected,Returned);
        } 

    }

}