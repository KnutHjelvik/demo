using System;
using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.ByCore.IO;

namespace Timpex.Reporting.Filesetup
{
    public class EntryPoint
    {
        private CommandHandlerContainer _commandHandlerContainer = CommandHandlerContainer.New();
        private DirectoryImpl _directoryImpl = DirectoryImpl.New();

        public static Func<EntryPoint> New = () => new EntryPoint();

        public EntryPoint(CommandHandlerContainer commandHandlerContainer)
        {
            _commandHandlerContainer = commandHandlerContainer;
        }

        public virtual void Start(string[] args)
        {
            StartCore(args);
        }

        private void StartCore(string[] args)
        {
            var command = String.Empty;
            if (args.Length <= 0)
            {
                var startpoint = _commandHandlerContainer.ResolveFor(command);
                startpoint.Start();
            }
            else
            {
                var rootPath = "C:/Devel/TRDeployment/";
                _directoryImpl.Remove(rootPath);
                command = args[0];
                var startPoint = _commandHandlerContainer.ResolveFor(command);
                if (startPoint != null)
                    startPoint.Start();
            }
        }

        public EntryPoint()
        {
        }
    }
}