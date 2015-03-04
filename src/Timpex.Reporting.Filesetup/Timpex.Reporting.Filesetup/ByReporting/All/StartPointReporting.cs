using System;
using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.ByReporting.DataSet;
using Timpex.Reporting.Filesetup.ByReporting.DataSource;
using Timpex.Reporting.Filesetup.ByReporting.Reports.Std.Eng;
using Timpex.Reporting.Filesetup.ByReporting.Reports.Std.Nor;
using Timpex.Reporting.Filesetup.ByReporting.Reports.Utv.Eng;
using Timpex.Reporting.Filesetup.ByReporting.Reports.Utv.Nor;

namespace Timpex.Reporting.Filesetup.ByReporting.All
{
    public class StartPointReporting:StartPoint
    {
        private StartPoint _startpointDataSet = StartpointDataSet.New();
        private StartPoint _startpointDataSource = StartpointDataSource.New();
        private StartPoint _startpointReports = StartpointReports.New();
        private StartPoint _startpointReportsEng = StartpointReportsEng.New();
        private StartPoint _startpointReportsEngUtv = StartpointReportsEngUtv.New();
        private StartPoint _startpointReportsNorUtv = StartpointReportsUtv.New();

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
            _startpointReportsEngUtv.Start();
            _startpointReportsNorUtv.Start();
        }

        private void Init()
        {
            _startpointDataSet = _commandHandlerContainer.Resolve<StartpointDataSet>();
            _startpointDataSource = _commandHandlerContainer.Resolve<StartpointDataSource>();
            _startpointReports = _commandHandlerContainer.Resolve<StartpointReports>();
            _startpointReportsEng = _commandHandlerContainer.Resolve<StartpointReportsEng>();
            _startpointReportsEngUtv = _commandHandlerContainer.Resolve<StartpointReportsEngUtv>();
            _startpointReportsNorUtv = _commandHandlerContainer.Resolve<StartpointReportsUtv>();
        }

        private void Resolve()
        {
            DataSetModule.New();
            DataSourceModule.New();
            ReportsNorModule.New();
            ReportsEngModule.New();
            ReportsNorUtvModule.New();
            ReportsEngUtvModule.New();
        }

        public StartPointReporting()
        {
        }
    }
}