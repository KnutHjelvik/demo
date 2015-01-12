using NUnit.Framework;

namespace Timpex.Kata.Advanced.ByWord._Spec._WordStringTrimmer.New
{
    [TestFixture]
    class When_Trim:Trim_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Remove_Last_Space()
        {
            Assert.AreEqual(Returned,Expected);
        } 

    }



}