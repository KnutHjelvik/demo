using NUnit.Framework;
using Rhino.Mocks;
using Timpex.Reporting.Filesetup.ByReporting.DataSet;

namespace Timpex.Reporting.Filesetup.ByReporting._Spec._DataSetModule
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
            CommandHandlerContainer.AssertWasCalled(x=>x.RegisterStartpoint<StartpointDataSet>("datasets"));
        }

    }

}