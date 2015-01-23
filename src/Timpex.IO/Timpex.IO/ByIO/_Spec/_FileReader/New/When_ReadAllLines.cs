using NUnit.Framework;

namespace Timpex.IO.ByIO._Spec._FileReader.New
{
    [TestFixture]
    class When_ReadAllLines:ReadAllLines_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }



        [Test]
        public void It_Should_Return_All_Lines()
        {
            Assert.AreEqual(Expected,Returned);
        } 

    }

}