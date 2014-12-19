using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Timpex.Kata._Spec_Advanced.NumberCounter.New.Get_Act
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
        public void It_Should_Return_Expected()
        {
            Assert.AreEqual(expected,returned);
        }
    }
}
