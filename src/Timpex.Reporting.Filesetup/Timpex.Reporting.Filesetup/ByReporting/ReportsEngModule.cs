using System;
using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.ByReporting.Reports.Eng;

namespace Timpex.Reporting.Filesetup.ByReporting
{
    public class ReportsEngModule
    {
        private CommandHandlerContainer _commandHandlerContainer = CommandHandlerContainer.New();
        private string Command = "reports_eng";

        public static Func<ReportsEngModule> New = () => new ReportsEngModule();

        public ReportsEngModule()
        {
            _commandHandlerContainer.RegisterStartpoint<StartpointReportsEng>(Command);
        } 
    }
}