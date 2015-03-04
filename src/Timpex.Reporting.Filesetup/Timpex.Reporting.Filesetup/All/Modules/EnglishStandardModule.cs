using System;
using Timpex.Reporting.Filesetup.All.Startpoints;
using Timpex.Reporting.Filesetup.ByCore;

namespace Timpex.Reporting.Filesetup.All.Modules
{
    public class EnglishStandardModule
    {
        private CommandHandlerContainer _commandHandlerContainer = CommandHandlerContainer.New();
        private string Command = "eng_std";

        public static Func<EnglishStandardModule> New = () => new EnglishStandardModule();

        public EnglishStandardModule()
        {
            _commandHandlerContainer.RegisterStartpoint<StartpointEnglishStandard>(Command);
        } 
    }
}