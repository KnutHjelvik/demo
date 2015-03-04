using System;
using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.ByReporting.Reports.Utv.Eng;

namespace Timpex.Reporting.Filesetup.ByReporting
{
    public class ReportsEngUtvModule
    {
        private CommandHandlerContainer _commandHandlerContainer = CommandHandlerContainer.New();
        private string Command = "reports_eng_utv";

        public static Func<ReportsEngUtvModule> New = () => new ReportsEngUtvModule();

        public ReportsEngUtvModule()
        {
            _commandHandlerContainer.RegisterStartpoint<StartpointReportsEngUtv>(Command);
        } 
    }
}