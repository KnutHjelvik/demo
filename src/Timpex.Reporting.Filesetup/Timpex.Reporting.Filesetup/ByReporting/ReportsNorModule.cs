using System;
using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.ByReporting.Reports.Std.Nor;

namespace Timpex.Reporting.Filesetup.ByReporting
{
    public class ReportsNorModule
    {
        private CommandHandlerContainer _commandHandlerContainer = CommandHandlerContainer.New();
        private string Command = "reports_nor";

        public static Func<ReportsNorModule> New = () => new ReportsNorModule();

        public ReportsNorModule()
        {
            _commandHandlerContainer.RegisterStartpoint<StartpointReports>(Command);
        }
    }
}