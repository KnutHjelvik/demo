using NUnit.Framework;

namespace Timpex.Reporting.Filesetup.ByCore.Reading.Excluder._Spec._ExcludeFilesByPrefix.New
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
        public void It_Should_Exclude_And_Return_Expected()
        {
            Assert.AreEqual(Expected,Returned);
        } 

    }

}