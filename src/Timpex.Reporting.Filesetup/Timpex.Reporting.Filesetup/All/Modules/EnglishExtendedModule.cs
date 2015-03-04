using System;
using Timpex.Reporting.Filesetup.All.Startpoints;
using Timpex.Reporting.Filesetup.ByCore;

namespace Timpex.Reporting.Filesetup.All.Modules
{
    public class EnglishExtendedModule
    {
        private CommandHandlerContainer _commandHandlerContainer = CommandHandlerContainer.New();
        private string Command = "eng_utv";

        public static Func<EnglishExtendedModule> New = () => new EnglishExtendedModule();

        public EnglishExtendedModule()
        {
            _commandHandlerContainer.RegisterStartpoint<StartpointEnglishExtended>(Command);
        } 
    }
}