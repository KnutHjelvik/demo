using System;
using Timpex.Reporting.Filesetup.All.Startpoints;
using Timpex.Reporting.Filesetup.ByCore;

namespace Timpex.Reporting.Filesetup.All.Modules
{
    public class NorwegianExtendedModule
    {
        private CommandHandlerContainer _commandHandlerContainer = CommandHandlerContainer.New();
        private string Command = "nor_utv";

        public static Func<NorwegianExtendedModule> New = () => new NorwegianExtendedModule();

        public NorwegianExtendedModule()
        {
            _commandHandlerContainer.RegisterStartpoint<StartpointNorwegianExtended>(Command);
        } 
    }
}