using NUnit.Framework;
using Rhino.Mocks;

namespace Timpex.Sscc.ByIO._Spec._CodeWriter.New
{
    [TestFixture]
    class When_Write:Write_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Resolve_Codes()
        {
            CodeDtoArrayCreater.AssertWasCalled(x=>x.Create(dtos));
        }

        [Test]
        public void It_Should_Write_Codes()
        {
            CodeWriterCore.AssertWasCalled(x=>x.WriteCodes(array));
        }

    }

}