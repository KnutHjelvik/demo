using NUnit.Framework;

namespace Timpex.Core.ByStrings._Spec._Strings.New
{
    [TestFixture]
    class When_Concat:Concat_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Return_Expected_String()
        {
            Assert.AreEqual(Expected,Returned);
        } 

    }

}