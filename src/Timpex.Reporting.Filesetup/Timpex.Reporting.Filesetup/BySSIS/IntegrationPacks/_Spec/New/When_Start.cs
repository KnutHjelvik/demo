﻿using NUnit.Framework;
using Rhino.Mocks;
using Timpex.Reporting.Filesetup.ByCore;

namespace Timpex.Reporting.Filesetup.BySsis.IntegrationPacks._Spec.New
{
    [TestFixture]
    class When_Start:Start_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Execute_FileTransfer()
        {
            FileTransferExecuter.AssertWasCalled(x=>x.Execute(Arg<TransferInformation>.Is.Anything,Arg<AcceptedExtensions>.Is.Anything));
        } 

    }

}