using System;
using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.ByDeployment;
using Timpex.Reporting.Filesetup.ByReporting.DataSet;
using Timpex.Reporting.Filesetup.ByReporting.DataSource;
using Timpex.Reporting.Filesetup.ByReporting.Reports.Std.Eng;
using Timpex.Reporting.Filesetup.ByReporting.Reports.Std.Nor;
using Timpex.Reporting.Filesetup.ByReporting.Reports.Utv.Eng;
using Timpex.Reporting.Filesetup.ByReporting.Reports.Utv.Nor;
using Timpex.Reporting.Filesetup.BySql;
using Timpex.Reporting.Filesetup.BySsis.Batch;
using Timpex.Reporting.Filesetup.BySsis.IntegrationPacks;

namespace Timpex.Reporting.Filesetup.All.Startpoints
{
    public class StartpointAll:StartPoint
    {
        public static Func<StartpointAll> New = () => new StartpointAll();
        private CommandHandlerContainer _commandHandlerContainer = CommandHandlerContainer.New();
        private StartPoint _startpointSsisBatch;
        private StartPoint _startpointIntegrationPacks;
        private StartPoint _startpointDataSet;
        private StartPoint _startpointDataSource;
        private StartPoint _startpointReports;
        private StartPoint _startpointReportsEng;
        private StartPoint _startpointSql;
        private StartPoint _startpointDeployment;
        private StartPoint _startpointReportsEngUtv;
        private StartPoint _startpointReportsUtv;

        public StartpointAll(CommandHandlerContainer commandHandlerContainer)
        {
            _commandHandlerContainer = commandHandlerContainer;
        }

        public void Start()
        {
            Resolve();
            StartAll();
        }

        private void StartAll()
        {
            _startpointIntegrationPacks.Start();
            _startpointSsisBatch.Start();
            _startpointDataSet.Start();
            _startpointDataSource.Start();
            _startpointReports.Start();
            _startpointReportsEng.Start();
            _startpointSql.Start();
            _startpointDeployment.Start();
            _startpointReportsEngUtv.Start();
            _startpointReportsUtv.Start();
        }

        private void Resolve()
        {
            _startpointIntegrationPacks = _commandHandlerContainer.Resolve<StartpointIntegrationPacks>();
            _startpointSsisBatch = _commandHandlerContainer.Resolve<StartpointSSISBatch>();
            _startpointDataSet = _commandHandlerContainer.Resolve<StartpointDataSet>();
            _startpointDataSource = _commandHandlerContainer.Resolve<StartpointDataSource>();
            _startpointReports = _commandHandlerContainer.Resolve<StartpointReports>();
            _startpointReportsEng = _commandHandlerContainer.Resolve<StartpointReportsEng>();
            _startpointSql = _commandHandlerContainer.Resolve<StartpointSql>();
            _startpointDeployment = _commandHandlerContainer.Resolve<StartpointDeployment>();
            _startpointReportsEngUtv = _commandHandlerContainer.Resolve<StartpointReportsEngUtv>();
            _startpointReportsUtv = _commandHandlerContainer.Resolve<StartpointReportsUtv>();
        }

        public StartpointAll()
        {
        }
    }
}