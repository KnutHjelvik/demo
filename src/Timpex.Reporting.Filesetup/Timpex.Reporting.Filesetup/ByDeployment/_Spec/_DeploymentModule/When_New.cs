using NUnit.Framework;
using Rhino.Mocks;
using Timpex.Reporting.Filesetup.BySql;

namespace Timpex.Reporting.Filesetup.ByDeployment._Spec._DeploymentModule
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
            CommandHandlerContainer.AssertWasCalled(x=>x.RegisterStartpoint<StartpointDeployment>("deployment"));
        }

    }

}