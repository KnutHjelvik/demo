using System;
using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.BySsis.Batch;

namespace Timpex.Reporting.Filesetup.BySsis
{
    public class BatchModule
    {
        private CommandHandlerContainer _commandHandlerContainer = CommandHandlerContainer.New();
        private string Command = "bat_ssis";

        public static Func<BatchModule> New = () => new BatchModule();

        public BatchModule()
        {
            _commandHandlerContainer.RegisterStartpoint<StartpointSSISBatch>(Command);
        } 
    }
}