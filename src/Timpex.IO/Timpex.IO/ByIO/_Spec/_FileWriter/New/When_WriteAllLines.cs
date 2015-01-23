using System.IO;
using NUnit.Framework;
using Rhino.Mocks;

namespace Timpex.IO.ByIO._Spec._FileWriter.New
{
    [TestFixture]
    class When_WriteAllLines:WriteAllLines_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }



        [Test]
        public void It_Should_Return_All_Lines()
        {
           FileImpl.AssertWasCalled(x=>x.WriteLines(Path,lines));
        } 

    }

}