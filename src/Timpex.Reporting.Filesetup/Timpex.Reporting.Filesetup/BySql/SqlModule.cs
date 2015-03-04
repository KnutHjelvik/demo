using System;
using Timpex.Reporting.Filesetup.ByCore;

namespace Timpex.Reporting.Filesetup.BySql
{
    public class SqlModule
    {
        private CommandHandlerContainer _commandHandlerContainer = CommandHandlerContainer.New();
        private string Command = "sql";

        public static Func<SqlModule> New = () => new SqlModule();

        public SqlModule()
        {
            _commandHandlerContainer.RegisterStartpoint<StartpointSql>("sql");
        }
    }
}