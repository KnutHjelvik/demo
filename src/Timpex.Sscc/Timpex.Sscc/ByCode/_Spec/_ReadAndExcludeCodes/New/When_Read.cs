using NUnit.Framework;

namespace Timpex.Sscc.ByCode._Spec._ReadAndExcludeCodes.New
{
    [TestFixture]
    class When_Read:Read_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Return_Expected_List()
        {
            Assert.AreEqual(Expected,Returned);
        }

        [Test]
        public void It_Should_Contain_Same_Code1()
        {
            Assert.AreEqual(code1,Expected[0]);
        }

        [Test]
        public void It_Should_Contain_Same_Code2()
        {
            Assert.AreEqual(code2, Expected[1]);
        }

    }

}