using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Timpex.Kata._Spec_Advanced.NumberCounter.New.Increment_Act
{
    [TestFixture]
    class When_IncrementTwice:IncrementTwice_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void When_Increment_Once_Again()
        {
            Assert.AreEqual(2, Returned);
        }
    }
}
