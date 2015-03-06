using System;
using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.ByDeployment;
using Timpex.Reporting.Filesetup.ByReporting.DataSet;
using Timpex.Reporting.Filesetup.ByReporting.DataSource;
using Timpex.Reporting.Filesetup.ByReporting.Reports.Utv.Nor;
using Timpex.Reporting.Filesetup.BySql;
using Timpex.Reporting.Filesetup.BySsis.Batch;
using Timpex.Reporting.Filesetup.BySsis.IntegrationPacks;

namespace Timpex.Reporting.Filesetup.All.Startpoints
{
    public class StartpointNorwegianExtended:StartPoint
    {
        public static Func<StartpointNorwegianExtended> New = () => new StartpointNorwegianExtended();
        private CommandHandlerContainer _commandHandlerContainer = CommandHandlerContainer.New();
        private StartPoint _startpointSsisBatch;
        private StartPoint _startpointIntegrationPacks;
        private StartPoint _startpointDataSet;
        private StartPoint _startpointDataSource;
        private StartPoint _startpointSql;
        private StartPoint _startpointDeployment;
        private StartPoint _startpointReportsNorUtv;
        private StartPoint _startpointCompression;

        public StartpointNorwegianExtended(CommandHandlerContainer commandHandlerContainer)
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
            _startpointSql.Start();
            _startpointDeployment.Start();
            _startpointReportsNorUtv.Start();
            _startpointCompression.Start();
        }

        private void Resolve()
        {
            _startpointIntegrationPacks = _commandHandlerContainer.Resolve<StartpointIntegrationPacks>();
            _startpointSsisBatch = _commandHandlerContainer.Resolve<StartpointSSISBatch>();
            _startpointDataSet = _commandHandlerContainer.Resolve<StartpointDataSet>();
            _startpointDataSource = _commandHandlerContainer.Resolve<StartpointDataSource>();
            _startpointSql = _commandHandlerContainer.Resolve<StartpointSql>();
            _startpointDeployment = _commandHandlerContainer.Resolve<StartpointDeployment>();
            _startpointReportsNorUtv = _commandHandlerContainer.Resolve<StartpointReportsUtv>();
            _startpointCompression = _commandHandlerContainer.Resolve<StartpointCompression>();
        }

        public StartpointNorwegianExtended()
        {
        }
    }
}