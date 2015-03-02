using NUnit.Framework;

namespace Timpex.Reporting.Filesetup.ByCore.Factory._FileInfoFactory.New
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
        public void It_Should_Return_FileInfo_With_Name()
        {
            Assert.AreEqual(Name,Returned.Name);
        }     
        
        [Test]
        public void It_Should_Return_FileInfo_With_Extension()
        {
            Assert.AreEqual(Extension,Returned.Extension);
        }

        [Test]
        public void It_Should_Return_FileInfo_With_Path()
        {
            Assert.AreEqual(Path,Returned.Path);
        }

    }

}