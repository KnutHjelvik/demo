using System;
using Timpex.Reporting.Filesetup.ByCore;

namespace Timpex.Reporting.Filesetup.ByDeployment
{
    public class DeploymentModule
    {
        private CommandHandlerContainer _commandHandlerContainer = CommandHandlerContainer.New();
        private string Command = "deployment";

        public static Func<DeploymentModule> New = () => new DeploymentModule();

        public DeploymentModule()
        {
            _commandHandlerContainer.RegisterStartpoint<StartpointDeployment>(Command);
        } 
    }
}