using System;
using NUnit.Framework;
using Rhino.Mocks;

namespace Timpex.Reporting.Filesetup.ByCore._Spec._FileTransferExecuter.New
{
    [TestFixture]
    class When_Execute:Execute_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Copy_Files()
        {
            Copier.AssertWasCalled(x=>x.Copy(Files,Destination));
        }

        [Test]
        public void It_Should_Log()
        {
            ConsoleImpl.AssertWasCalled(x => x.Write(info));
        }

    }

}