using System;
using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.BySsis.IntegrationPacks;

namespace Timpex.Reporting.Filesetup.BySsis
{
    public class IntegrationPacksModule
    {
        private CommandHandlerContainer _commandHandlerContainer = CommandHandlerContainer.New();
        private string Command = "integration";

        public static Func<IntegrationPacksModule> New = () => new IntegrationPacksModule();

        public IntegrationPacksModule()
        {
            _commandHandlerContainer.RegisterStartpoint<StartpointIntegrationPacks>(Command);
        } 
    }
}