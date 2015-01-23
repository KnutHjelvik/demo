using NUnit.Framework;

namespace Timpex.Core.ByDateTime._Spec._DateAndTimeStringConverter.New
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
        public void It_Should_Return_Expected_Date_As_String()
        {
            Assert.AreEqual(Expected,Returned);
        } 

    }

}