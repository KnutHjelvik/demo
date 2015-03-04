using System;
using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.ByReporting.All;

namespace Timpex.Reporting.Filesetup.ByReporting
{
    public class ReportingModule
    {
        private CommandHandlerContainer _commandHandlerContainer = CommandHandlerContainer.New();
        private string Command = "reporting";

        public static Func<ReportingModule> New = () => new ReportingModule();

        public ReportingModule()
        {
            _commandHandlerContainer.RegisterStartpoint<StartPointReporting>(Command);
        }  
    }
}