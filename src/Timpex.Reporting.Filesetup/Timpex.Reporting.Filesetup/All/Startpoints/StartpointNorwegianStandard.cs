using System;
using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.ByDeployment;
using Timpex.Reporting.Filesetup.ByReporting.DataSet;
using Timpex.Reporting.Filesetup.ByReporting.DataSource;
using Timpex.Reporting.Filesetup.ByReporting.Reports.Std.Nor;
using Timpex.Reporting.Filesetup.BySql;
using Timpex.Reporting.Filesetup.BySsis.Batch;
using Timpex.Reporting.Filesetup.BySsis.IntegrationPacks;

namespace Timpex.Reporting.Filesetup.All.Startpoints
{
    public class StartpointNorwegianStandard:StartPoint
    {
        public static Func<StartpointNorwegianStandard> New = () => new StartpointNorwegianStandard();
        private CommandHandlerContainer _commandHandlerContainer = CommandHandlerContainer.New();
        private StartPoint _startpointSsisBatch;
        private StartPoint _startpointIntegrationPacks;
        private StartPoint _startpointDataSet;
        private StartPoint _startpointDataSource;
        private StartPoint _startpointReports;
        private StartPoint _startpointSql;
        private StartPoint _startpointDeployment;
        private StartPoint _startpointCompression;

        public StartpointNorwegianStandard(CommandHandlerContainer commandHandlerContainer)
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
            _startpointSql.Start();
            _startpointDeployment.Start();
            _startpointCompression.Start();
        }

        private void Resolve()
        {
            _startpointIntegrationPacks = _commandHandlerContainer.Resolve<StartpointIntegrationPacks>();
            _startpointSsisBatch = _commandHandlerContainer.Resolve<StartpointSSISBatch>();
            _startpointDataSet = _commandHandlerContainer.Resolve<StartpointDataSet>();
            _startpointDataSource = _commandHandlerContainer.Resolve<StartpointDataSource>();
            _startpointReports = _commandHandlerContainer.Resolve<StartpointReports>();
            _startpointSql = _commandHandlerContainer.Resolve<StartpointSql>();
            _startpointDeployment = _commandHandlerContainer.Resolve<StartpointDeployment>();
            _startpointCompression = _commandHandlerContainer.Resolve<StartpointCompression>();
        }

        public StartpointNorwegianStandard()
        {
        }
    }
}