using NUnit.Framework;
using Rhino.Mocks;

namespace Timpex.Sscc.ByIO._Spec._CodeWriterCore.New
{
    [TestFixture]
    class When_WriteCodes:WriteCodes_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Create_File()
        {
            FilenameGenerator.AssertWasCalled(x=>x.Generate());
        }

        [Test]
        public void It_Should_Write_Codes()
        {
            FileWriter.AssertWasCalled(x=>x.WriteAllLines(Filename,Codes));
        }

    }

}