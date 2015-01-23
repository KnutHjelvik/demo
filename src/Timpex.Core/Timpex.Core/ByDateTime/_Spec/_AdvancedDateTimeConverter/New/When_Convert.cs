using System;
using NUnit.Framework;

namespace Timpex.Core.ByDateTime._Spec._AdvancedDateTimeConverter.New
{
    [TestFixture]
    class When_Convert:Convert_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Return_Expected_String_Representing_Date()
        {
            Assert.AreEqual(Expected,Returned);
        }

         

    }

}