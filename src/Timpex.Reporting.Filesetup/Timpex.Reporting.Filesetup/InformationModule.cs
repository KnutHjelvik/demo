using System;
using Timpex.Reporting.Filesetup.ByCore;

namespace Timpex.Reporting.Filesetup
{
    public class InformationModule
    {
        private CommandHandlerContainer _commandHandlerContainer = CommandHandlerContainer.New();
        private string Command = String.Empty;

        public static Func<InformationModule> New = () => new InformationModule();

        public InformationModule()
        {
            _commandHandlerContainer.RegisterStartpoint<StartpointInformation>(Command);
        } 
    }
}