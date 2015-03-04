using System;
using Timpex.Reporting.Filesetup.All.Startpoints;
using Timpex.Reporting.Filesetup.ByCore;

namespace Timpex.Reporting.Filesetup.All.Modules
{
    public class AllModule
    {
        private CommandHandlerContainer _commandHandlerContainer = CommandHandlerContainer.New();
        private string Command = "all";

        public static Func<AllModule> New = () => new AllModule();

        public AllModule()
        {
            _commandHandlerContainer.RegisterStartpoint<StartpointAll>(Command);
        } 
    }
}