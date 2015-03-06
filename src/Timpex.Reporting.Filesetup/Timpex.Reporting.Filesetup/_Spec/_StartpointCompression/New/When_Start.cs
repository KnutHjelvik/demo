using NUnit.Framework;
using Rhino.Mocks;

namespace Timpex.Reporting.Filesetup._Spec._StartpointCompression.New
{

    [TestFixture]
    class When_Start:Start_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Compress_File()
        {
            ZipFileImpl.AssertWasCalled(x => x.CreateZip(source, dest + "/Reporting.Zip"));
        } 

    }

}