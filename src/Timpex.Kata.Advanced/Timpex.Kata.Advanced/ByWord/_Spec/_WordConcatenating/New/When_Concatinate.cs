using NUnit.Framework;

namespace Timpex.Kata.Advanced.ByWord._Spec._WordConcatenating.New
{
    [TestFixture]
    class When_Concatinate:Concatinate_Act      
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Concat_Word_And_Counter()
        {
            Assert.AreEqual(Expected,Returned);
        }

         

    }

}