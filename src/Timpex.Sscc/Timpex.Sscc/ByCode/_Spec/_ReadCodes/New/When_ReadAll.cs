using System.Linq;
using NUnit.Framework;
using Rhino.Mocks;

namespace Timpex.Sscc.ByCode._Spec._ReadCodes.New
{
    [TestFixture]
    class When_ReadAll:ReadAll_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_should_Read_Files()
        {
            FileReader.AssertWasCalled(x=> x.ReadAllLines(Path));
        }

        [Test]
        public void It_Should_Create_List_Wrapper()
        {
            CodelistFactory.AssertWasCalled(x=>x.SanitizeCodeList(strings.ToList()));
        }

        [Test]
        public void It_Should_Return_Expected_CodeList()
        {
            Assert.AreSame(Expected,Returned);
        }


    }

}