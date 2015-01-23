﻿using NUnit.Framework;

namespace Timpex.Sscc.ByIO._Spec._FilePrefix.New
{
    [TestFixture]
    class When_Get:Get_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Return_Expected_Prefix()
        {
            Assert.AreEqual(Expected,Returned);
        } 

    }

}