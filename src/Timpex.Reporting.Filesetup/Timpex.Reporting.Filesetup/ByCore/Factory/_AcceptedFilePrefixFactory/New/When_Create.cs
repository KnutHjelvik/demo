using NUnit.Framework;

namespace Timpex.Reporting.Filesetup.ByCore.Factory._AcceptedFilePrefixFactory.New
{
    [TestFixture]
    class When_Create:Create_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Create_Instance()
        {
            Assert.AreEqual(Expected,Returned);
        } 

    }

}