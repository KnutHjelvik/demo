using System;
using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.ByReporting.DataSource;

namespace Timpex.Reporting.Filesetup.ByReporting
{
    public class DataSourceModule
    {
        private CommandHandlerContainer _commandHandlerContainer = CommandHandlerContainer.New();
        private string Command = "datasources";

        public static Func<DataSourceModule> New = () => new DataSourceModule();

        public DataSourceModule()
        {
            _commandHandlerContainer.RegisterStartpoint<StartpointDataSource>(Command);
        } 
    }
}