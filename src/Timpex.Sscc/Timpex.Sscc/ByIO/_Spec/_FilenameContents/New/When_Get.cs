using NUnit.Framework;

namespace Timpex.Sscc.ByIO._Spec._FilenameContents.New
{
    [TestFixture]
    class When_Get:Get_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Return_Expected_Filename_Contents()
        {
            Assert.AreEqual(Expected,Returned);
        } 

    }

}