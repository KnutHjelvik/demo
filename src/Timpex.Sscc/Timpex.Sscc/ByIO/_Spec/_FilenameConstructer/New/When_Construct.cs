using NUnit.Framework;

namespace Timpex.Sscc.ByIO._Spec._FilenameConstructer.New
{
    [TestFixture]
    class When_Construct:Construct_Act
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