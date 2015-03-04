using NUnit.Framework;
using Rhino.Mocks;
using Timpex.Reporting.Filesetup.ByCore;

namespace Timpex.Reporting.Filesetup.BySql._Spec._StartpointSql.New
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
        public void It_Should_Copy_Master_Sql()
        {
            FileTransferExecuter.AssertWasCalled(x=>x.Execute(Arg<TransferInformation>.Is.Anything,Arg<AcceptedExtensions>.Is.Anything));
        }



        [Test]
        public void It_Should_Copy_Updates_Sql()
        {
            FileTransferExecuter.AssertWasCalled(x => x.Execute(Arg<TransferInformation>.Is.Anything, Arg<AcceptedExtensions>.Is.Anything, Arg<AcceptedPrefix>.Is.Anything));
        }

        [Test]
        public void It_Should_Merge_Master_And_Updates()
        {
            SqlScriptMerger.AssertWasCalled(x=>x.Merge(sqlDestMasterPath, sqlDestUpdatesPath,sqlRootPath + "/Reporting.Master + Updates.sql"));
        }

        [Test]
        public void It_Should_Merge_Updates()
        {
            SqlScriptMerger.AssertWasCalled(x => x.Merge(sqlDestUpdatesPath, sqlRootPath + "/Reporting.Updates.sql"));
        }

    }

}