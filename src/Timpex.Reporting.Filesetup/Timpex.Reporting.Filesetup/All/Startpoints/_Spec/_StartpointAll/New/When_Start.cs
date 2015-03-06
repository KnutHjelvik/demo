using NUnit.Framework;
using Rhino.Mocks;

namespace Timpex.Reporting.Filesetup.All.Startpoints._Spec._StartpointAll.New
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
        public void It_Should_Start_SSIS_Integration_Packs_Startpoint()
        {
            StartpointIntegrationPacks.AssertWasCalled(x=>x.Start());
        }

        [Test]
        public void It_Should_Start_SSIS_Batch_Startpoint()
        {
            StartpointSsisBatch.AssertWasCalled(x => x.Start());
        }

        [Test]
        public void It_Should_Start_DataSet_Startpoint()
        {
            StartpointDataset.AssertWasCalled(x => x.Start());
        }

        [Test]
        public void It_Should_Start_SSIS_Datasource_Startpoint()
        {
            StartpointDataSource.AssertWasCalled(x => x.Start());
        }

        [Test]
        public void It_Should_Start_Sql_Startpoint()
        {
            StartpointSql.AssertWasCalled(x => x.Start());
        }

        [Test]
        public void It_Should_Start_Deployment_Startpoint()
        {
            StartpointDeployment.AssertWasCalled(x => x.Start());
        }

        [Test]
        public void It_Should_Start_Reports_Startpoint()
        {
            StartpointReportsEngUtv.AssertWasCalled(x => x.Start());
        }

        [Test]
        public void It_Should_Start_ReportsEng_Startpoint()
        {
            StartpointReportsEng.AssertWasCalled(x => x.Start());
        }

        [Test]
        public void It_Should_Start_Reports_Utv_Startpoint()
        {
            StartpointReportsUtv.AssertWasCalled(x => x.Start());
        }

        [Test]
        public void It_Should_Start_Reports_Nor_Startpoint()
        {
            StartpointReports.AssertWasCalled(x => x.Start());
        }

        [Test]
        public void It_Should_Start_Compression_Startpoint()
        {
            StartpointReports.AssertWasCalled(x => x.Start());
        } 
    }

}