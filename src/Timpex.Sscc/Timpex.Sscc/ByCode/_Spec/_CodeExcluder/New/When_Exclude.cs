using NUnit.Framework;
using Rhino.Mocks;

namespace Timpex.Sscc.ByCode._Spec._CodeExcluder.New
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
        public void It_Should_Contain_Valid_SSCC_Code()
        {
            Assert.AreEqual(Expected,Returned);
        }



    }

}