using NUnit.Framework;

namespace Timpex.Reporting.Filesetup.ByCore.Reading.Excluder._Spec._FileExcluder.New
{
    [TestFixture]
    class When_Exclude:Exclude_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Exclude_And_Return_Expected_List()
        {
            Assert.AreEqual(Expected,Returned);
        } 

    }

}