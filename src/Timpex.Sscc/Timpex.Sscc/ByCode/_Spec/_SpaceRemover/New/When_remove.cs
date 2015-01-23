using NUnit.Framework;

namespace Timpex.Sscc.ByCode._Spec._SpaceRemover.New
{
    [TestFixture]
    class When_Remove:Remove_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Remove_Spaces()
        {
            Assert.AreEqual(Expected,Returned);
        } 

    }

}