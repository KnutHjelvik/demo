using NUnit.Framework;
using Rhino.Mocks;
using Timpex.Reporting.Filesetup.ByReporting.DataSource;

namespace Timpex.Reporting.Filesetup.ByReporting._Spec._DataSourceModule
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
            CommandHandlerContainer.AssertWasCalled(x=>x.RegisterStartpoint<StartpointDataSource>("datasources"));
        }

    }

}