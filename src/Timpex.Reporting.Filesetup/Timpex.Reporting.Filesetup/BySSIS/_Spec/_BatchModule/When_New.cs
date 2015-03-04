using NUnit.Framework;
using Rhino.Mocks;
using Timpex.Reporting.Filesetup.BySsis.Batch;

namespace Timpex.Reporting.Filesetup.BySsis._Spec._BatchModule
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
            CommandHandlerContainer.AssertWasCalled(x=>x.RegisterStartpoint<StartpointSSISBatch>("bat_ssis"));
        }

    }

}