using NUnit.Framework;
using Rhino.Mocks;
using Timpex.Reporting.Filesetup.All.Startpoints;
using Timpex.Reporting.Filesetup.BySsis.Batch;

namespace Timpex.Reporting.Filesetup.All.Modules._Spec._AllModules
{
    [TestFixture]
    class When_New:New_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test] 
        public void It_Should_Register_Module()
        {
            CommandHandlerContainer.AssertWasCalled(x=>x.RegisterStartpoint<StartpointAll>("all"));
        }

    }

}