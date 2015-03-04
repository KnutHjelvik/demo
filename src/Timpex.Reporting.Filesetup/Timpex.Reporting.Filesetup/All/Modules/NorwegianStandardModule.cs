using System;
using Timpex.Reporting.Filesetup.All.Startpoints;
using Timpex.Reporting.Filesetup.ByCore;

namespace Timpex.Reporting.Filesetup.All.Modules
{
    public class NorwegianStandardModule
    {
        private CommandHandlerContainer _commandHandlerContainer = CommandHandlerContainer.New();
        private string Command = "nor_std";

        public static Func<NorwegianStandardModule> New = () => new NorwegianStandardModule();

        public NorwegianStandardModule()
        {
            _commandHandlerContainer.RegisterStartpoint<StartpointNorwegianStandard>(Command);
        } 
    }
}