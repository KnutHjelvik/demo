using System;
using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.ByReporting.DataSet;

namespace Timpex.Reporting.Filesetup.ByReporting
{
    public class DataSetModule
    {
        private CommandHandlerContainer _commandHandlerContainer = CommandHandlerContainer.New();
        private string Command = "datasets";

        public static Func<DataSetModule> New = () => new DataSetModule();

        public DataSetModule()
        {
            _commandHandlerContainer.RegisterStartpoint<StartpointDataSet>(Command);
        } 
    }
}