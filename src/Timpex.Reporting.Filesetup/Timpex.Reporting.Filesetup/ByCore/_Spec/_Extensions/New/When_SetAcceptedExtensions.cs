using NUnit.Framework;

namespace Timpex.Reporting.Filesetup.ByCore._Spec._Extensions.New
{
    [TestFixture]
    class When_SetAcceptedExtensions : SetAcceptedExtensions_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Contain_Bat()
        {
            Assert.AreEqual(Bat,Sut.Get(Bat));
        }


        [Test]
        public void It_Should_Contain_Exptected_Dtsx()
        {
            Assert.AreEqual(Dtsx, Sut.Get(Dtsx));
        }

        [Test]
        public void It_Should_Not_Contain_Extension()
        {
            Assert.AreEqual(null, Sut.Get("dsaa"));
        }



    }

}