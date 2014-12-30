using NUnit.Framework;

namespace Timpex.Kata.Advanced.ByFactory._Spec._WordFactory.New
{
    [TestFixture]
    class When_Create:Create_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Return_Correct_Type()
        {
            Assert.AreSame(Expected,Returned.GetType());
        }
 

    }

}