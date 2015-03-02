using System;
using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.ByReporting;
using Timpex.Reporting.Filesetup.BySSIS.Batch;

namespace Timpex.Reporting.Filesetup.BySSIS
{
    public class BatchModule
    {
        private CommandHandlerContainer _commandHandlerContainer = CommandHandlerContainer.New();
        private string Command = "bat_ssis";

        public static Func<DataSetModule> New = () => new DataSetModule();

        public BatchModule()
        {
            _commandHandlerContainer.RegisterStartpoint<StartpointSSISBatch>(Command);
        } 
    }
}