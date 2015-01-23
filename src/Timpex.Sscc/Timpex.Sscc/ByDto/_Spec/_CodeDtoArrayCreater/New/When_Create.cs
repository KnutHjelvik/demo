using NUnit.Framework;

namespace Timpex.Sscc.ByDto._Spec._CodeDtoArrayCreater.New
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
        public void It_Should_Return_Expected_Array_Of_Dto_String_Representations()
        {
            Assert.AreEqual(Expected,Returned);
        }

        [Test]
        public void It_Should_Contain_Dto1()
        {
            Assert.AreEqual(Returned[0],DtoString1);
        }

        [Test]
        public void It_Should_Contain_Dto2()
        {
            Assert.AreEqual(Returned[1], DtoString2);
        }

    }

}