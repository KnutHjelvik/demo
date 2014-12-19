using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Timpex.Kata._Spec_Advanced.NumberCounter.New.Increment_Act
{
    [TestFixture]
    class When_Increment:Increment_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void When_Increment_Once()
        {
            Assert.AreEqual(1,Returned);
        }
    }
}
