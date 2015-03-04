using NUnit.Framework;
using Rhino.Mocks;
using Timpex.Reporting.Filesetup.ByReporting.Reports.Std.Eng;

namespace Timpex.Reporting.Filesetup.ByReporting._Spec._ReportsEngModule
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
            CommandHandlerContainer.AssertWasCalled(x=>x.RegisterStartpoint<StartpointReportsEng>("reports_eng"));
        }

    }

}