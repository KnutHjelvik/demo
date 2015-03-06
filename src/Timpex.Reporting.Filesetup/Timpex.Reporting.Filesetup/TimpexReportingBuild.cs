using System;
using Timpex.Reporting.Filesetup.All.Modules;
using Timpex.Reporting.Filesetup.ByDeployment;
using Timpex.Reporting.Filesetup.ByReporting;
using Timpex.Reporting.Filesetup.BySql;
using Timpex.Reporting.Filesetup.BySsis;

namespace Timpex.Reporting.Filesetup
{
    class TimpexReportingBuild
    {
        private static EntryPoint entryPoint = EntryPoint.New();

        static void Main(string[] args)
        {
            InitSubs();
            Init();
            entryPoint.Start(args);
        }


        private static void Init()
        {
            ReportingModule.New();
            SsisModule.New();
            AllModule.New();
            EnglishExtendedModule.New();
            EnglishStandardModule.New();
            NorwegianExtendedModule.New();
            NorwegianStandardModule.New();
        }

        private static void InitSubs()
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
        }
    }
}
