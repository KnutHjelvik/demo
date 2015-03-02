using System;
using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.ByReporting.DataSet;
using Timpex.Reporting.Filesetup.ByReporting.DataSource;
using Timpex.Reporting.Filesetup.ByReporting.Reports.Eng;
using Timpex.Reporting.Filesetup.ByReporting.Reports.Nor;

namespace Timpex.Reporting.Filesetup.ByReporting.All
{
    public class StartPointReporting:StartPoint
    {
        private StartPoint _startpointDataSet = StartpointDataSet.New();
        private StartPoint _startpointDataSource = StartpointDataSource.New();
        private StartPoint _startpointReports = StartpointReports.New();
        private StartPoint _startpointReportsEng = StartpointReportsEng.New();

        private CommandHandlerContainer _commandHandlerContainer =  CommandHandlerContainer.New();

        public static Func<StartPointReporting> New = () => new StartPointReporting();

        public StartPointReporting(CommandHandlerContainer commandHandlerContainer)
        {
            _commandHandlerContainer = commandHandlerContainer;
        }

        public void Start()
        {
            Resolve();
            Init();
            StartAll();
        }

        private void StartAll()
        {
            _startpointDataSet.Start();
            _startpointDataSource.Start();
            _startpointReports.Start();
            _startpointReportsEng.Start();
        }

        private void Init()
        {
            _startpointDataSet = _commandHandlerContainer.Resolve<StartpointDataSet>();
            _startpointDataSource = _commandHandlerContainer.Resolve<StartpointDataSource>();
            _startpointReports = _commandHandlerContainer.Resolve<StartpointReports>();
            _startpointReportsEng = _commandHandlerContainer.Resolve<StartpointReportsEng>();
        }

        private void Resolve()
        {
            DataSetModule.New();
            DataSourceModule.New();
            ReportsNorModule.New();
            ReportsEngModule.New();
        }

        public StartPointReporting()
        {
        }
    }
}