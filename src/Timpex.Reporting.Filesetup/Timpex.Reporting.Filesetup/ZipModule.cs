using System;
using Timpex.Reporting.Filesetup.ByCore;

namespace Timpex.Reporting.Filesetup
{
    public class ZipModule
    {
        private CommandHandlerContainer _commandHandlerContainer = CommandHandlerContainer.New();
        private string Command = "zip";

        public static Func<ZipModule> New = () => new ZipModule();

        public ZipModule()
        {
            _commandHandlerContainer.RegisterStartpoint<StartpointCompression>(Command);
        } 
    }
}