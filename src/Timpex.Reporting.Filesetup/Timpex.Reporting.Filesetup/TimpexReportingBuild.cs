using System;
using Timpex.Reporting.Filesetup.ByCore;

namespace Timpex.Reporting.Filesetup
{
    class TimpexReportingBuild
    {

        private static CommandHandlerContainer _commandHandler = CommandHandlerContainer.New();

        static void Main(string[] args)
        {
            Init();
            var command = args[0];
            var startPoint = _commandHandler.ResolveFor(command);
        }


        private static void Init()
        {

        }
    }
}
