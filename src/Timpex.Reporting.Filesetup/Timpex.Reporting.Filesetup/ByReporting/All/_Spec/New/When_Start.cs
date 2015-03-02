using NUnit.Framework;
using Rhino.Mocks;

namespace Timpex.Reporting.Filesetup.ByReporting.All._Spec.New
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
        public void It_Should_Start_Datasource_Startpoint()
        {
            StartpointDataSource.AssertWasCalled(x=>x.Start());
        }

        [Test]
        public void It_Should_Start_DataSet_Startpoint()
        {
            StartpointDataSet.AssertWasCalled(x => x.Start());
        }

        [Test]
        public void It_Should_Start_Reports_Startpoint()
        {
            StartpointReports.AssertWasCalled(x => x.Start());
        }

        [Test]
        public void It_Should_Start_ReportsEng_Startpoint()
        {
            StartPointReportsEng.AssertWasCalled(x => x.Start());
        } 

    }

}