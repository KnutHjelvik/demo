using NUnit.Framework;
using Rhino.Mocks;

namespace Timpex.Kata.Advanced._Spec._Timpex.New.PrintThird
{
    [TestFixture]
    class When_Print:Print_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }


        [Test]
        public void It_Should_Increment_Counter()
        {
            Counter.AssertWasCalled(x=>x.IncrementCount());
        }

        [Test]
        public void It_Should_Return_One()
        {
            Assert.AreEqual(Expected,Returned);
        }

    }

}