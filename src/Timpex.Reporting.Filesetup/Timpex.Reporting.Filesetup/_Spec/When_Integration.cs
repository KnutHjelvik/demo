using NUnit.Framework;
using Timpex.Reporting.Filesetup.All.Modules;
using Timpex.Reporting.Filesetup.All.Startpoints;
using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.ByDeployment;
using Timpex.Reporting.Filesetup.ByReporting;
using Timpex.Reporting.Filesetup.ByReporting.DataSource;
using Timpex.Reporting.Filesetup.BySql;
using Timpex.Reporting.Filesetup.BySsis;

namespace Timpex.Reporting.Filesetup._Spec
{
    [TestFixture]
    class When_Integration
    {
        [TestFixtureSetUp]
        public void Setup()
        {

        }

        [Test]
        public void It_Should_Execute()
        {
            ReportsEngModule.New();
            ReportsNorModule.New();
            ReportsEngUtvModule.New();
            ReportsNorUtvModule.New();
            DataSetModule.New();
            DataSourceModule.New();
            IntegrationPacksModule.New();
            BatchModule.New();
            DeploymentModule.New();
            SqlModule.New();
            InformationModule.New();
            ZipModule.New();
            ReportingModule.New();
            SsisModule.New();
            AllModule.New();
            EnglishExtendedModule.New();
            EnglishStandardModule.New();
            NorwegianExtendedModule.New();
            NorwegianStandardModule.New();
            var startpoint = CommandHandlerContainer.New().Resolve<StartpointAll>();
            startpoint.Start();
        }

         

    }

}