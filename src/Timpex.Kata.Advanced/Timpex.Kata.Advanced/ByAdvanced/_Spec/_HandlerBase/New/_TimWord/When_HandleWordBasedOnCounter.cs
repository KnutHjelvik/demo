﻿using NUnit.Framework;

namespace Timpex.Kata.Advanced.ByAdvanced._Spec._HandlerBase.New._TimWord
{
    [TestFixture]
    class When_HandleWordBasedOnCounter:HandleWordBasedOnCounter_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }


        [Test]
        public void It_Should_Return_Tim_Word()
        {
            Assert.AreEqual(Expected,Returned);
        }

    }

}