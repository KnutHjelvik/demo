using NUnit.Framework;

namespace Timpex.Sscc.ByIO._Spec._FilenameGenerator.New
{
    [TestFixture]
    class When_Generate:Generate_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Generate_FileName()
        {
            Assert.AreEqual(Expected,Returned);
        } 

    }

}