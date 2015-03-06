using System;
using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.BySsis.Batch;
using Timpex.Reporting.Filesetup.BySsis.IntegrationPacks;

namespace Timpex.Reporting.Filesetup.BySsis.All
{
    public class StartpointSsis:StartPoint
    {
        public static Func<StartpointSSISBatch> New = () => new StartpointSSISBatch();
        private CommandHandlerContainer _commandHandlerContainer = CommandHandlerContainer.New();
        private StartPoint _startpointSsisBatch;
        private StartPoint _startpointIntegrationPacks;
        private StartPoint _startpointCompression;

        public StartpointSsis(CommandHandlerContainer commandHandlerContainer)
        {
            _commandHandlerContainer = commandHandlerContainer;
        }

        public void Start()
        {
            Resolve();
            StartAll();
        }

        private void StartAll()
        {
            _startpointIntegrationPacks.Start();
            _startpointSsisBatch.Start();
            _startpointCompression.Start();
        }

        private void Resolve()
        {
            _startpointIntegrationPacks = _commandHandlerContainer.Resolve<StartpointIntegrationPacks>();
            _startpointSsisBatch = _commandHandlerContainer.Resolve<StartpointSSISBatch>();
            _startpointCompression = _commandHandlerContainer.Resolve<StartpointCompression>();
        }


        public StartpointSsis()
        {
        }
    }
}