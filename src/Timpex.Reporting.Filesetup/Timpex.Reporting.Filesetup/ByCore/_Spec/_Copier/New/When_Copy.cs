using NUnit.Framework;
using Rhino.Mocks;

namespace Timpex.Reporting.Filesetup.ByCore._Spec._Copier.New
{
    [TestFixture]
    class When_Copy:Copy_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Copy_File()
        {
            FileImpl.AssertWasCalled(x=>x.MoveFile(source,FQPath));
        } 

    }

}