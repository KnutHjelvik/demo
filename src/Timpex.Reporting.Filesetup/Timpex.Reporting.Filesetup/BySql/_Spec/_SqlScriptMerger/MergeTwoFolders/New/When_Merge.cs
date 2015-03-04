using NUnit.Framework;
using Rhino.Mocks;

namespace Timpex.Reporting.Filesetup.BySql._Spec._SqlScriptMerger.MergeTwoFolders.New
{
    [TestFixture]
    class When_Merge:Merge_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Merge_Files()
        {
            FileMerger.AssertWasCalled(x=>x.Merge(Files1,Files2,Destination));
        } 

    }

}