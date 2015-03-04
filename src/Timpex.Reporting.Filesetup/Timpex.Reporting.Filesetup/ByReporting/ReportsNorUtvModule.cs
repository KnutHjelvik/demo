using System;
using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.ByReporting.Reports.Utv.Nor;

namespace Timpex.Reporting.Filesetup.ByReporting
{
    public class ReportsNorUtvModule
    {
        private CommandHandlerContainer _commandHandlerContainer = CommandHandlerContainer.New();
        private string Command = "reports_nor_utv";

        public static Func<ReportsNorUtvModule> New = () => new ReportsNorUtvModule();

        public ReportsNorUtvModule()
        {
            _commandHandlerContainer.RegisterStartpoint<StartpointReportsUtv>(Command);
        } 
    }
}