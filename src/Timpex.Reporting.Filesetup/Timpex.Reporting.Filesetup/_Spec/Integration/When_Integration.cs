using System.IO;
using NUnit.Framework;
using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.ByReporting;
using Timpex.Reporting.Filesetup.ByReporting.All;

namespace Timpex.Reporting.Filesetup._Spec.Integration
{
    [TestFixture]
    class When_Integration
    {
        [Test]
        public void It_Should_Register_AndExecute_Module()
        {
            new ReportingModule();
            var module = CommandHandlerContainer.New().Resolve<StartPointReporting>();
            module.Start();
        }

    }

}