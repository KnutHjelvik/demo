﻿using NUnit.Framework;

namespace Timpex.Kata.Advanced.ByWord._Spec._PexWord.New
{
    [TestFixture]
    class When_GetValue:GetValue_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Return_Pex()
        {
            Assert.AreEqual(Expected,Result);
        }

    }

}