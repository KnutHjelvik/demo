using System;
using Timpex.Reporting.Filesetup.All.Modules;
using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.ByDeployment;
using Timpex.Reporting.Filesetup.ByReporting;
using Timpex.Reporting.Filesetup.BySql;
using Timpex.Reporting.Filesetup.BySsis;

namespace Timpex.Reporting.Filesetup
{
    class TimpexReportingBuild
    {
        private static CommandHandlerContainer _commandHandler = CommandHandlerContainer.New();

        static void Main(string[] args)
        {
            InitSubs();
            Init();
            var command = String.Empty;
            if (args.Length <= 0)
            {
                var startpoint = _commandHandler.ResolveFor(command);
                startpoint.Start();
            }
            else
            {
                command = args[0];
                var startPoint = _commandHandler.ResolveFor(command);
                if (startPoint != null)
                    startPoint.Start();
            }
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
        }
    }
}
