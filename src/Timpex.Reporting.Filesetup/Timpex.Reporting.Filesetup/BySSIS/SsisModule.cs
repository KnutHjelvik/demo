using System;
using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.BySsis.All;

namespace Timpex.Reporting.Filesetup.BySsis
{
    public class SsisModule
    {
        public static Func<SsisModule> New = () => new SsisModule();
        private CommandHandlerContainer _commandHandlerContainer = CommandHandlerContainer.New();
        private string command = "ssis";

        public SsisModule()
        {
            _commandHandlerContainer.RegisterStartpoint<StartpointSsis>("ssis");
        }
    }
}