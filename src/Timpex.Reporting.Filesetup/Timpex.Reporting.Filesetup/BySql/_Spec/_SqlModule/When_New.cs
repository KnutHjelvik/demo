using NUnit.Framework;
using Rhino.Mocks;

namespace Timpex.Reporting.Filesetup.BySql._Spec._SqlModule
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
            CommandHandlerContainer.AssertWasCalled(x=>x.RegisterStartpoint<StartpointSql>("sql"));
        }

    }

}