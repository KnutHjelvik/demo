using NUnit.Framework;

namespace Timpex.Reporting.Filesetup.ByCore.Factory._FilenameFactory.New
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
        public void It_Should_Return_FileName()
        {
            Assert.AreEqual(Expected,Returned);
        } 

    }

}