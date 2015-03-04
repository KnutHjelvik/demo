using System;
using NUnit.Framework;
using Rhino.Mocks;

namespace Timpex.Reporting.Filesetup._Spec._InformationModule
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
            CommandHandlerContainer.AssertWasCalled(x=>x.RegisterStartpoint<StartpointInformation>(String.Empty));
        }

    }

}