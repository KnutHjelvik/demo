using NUnit.Framework;

namespace Timpex.Sscc._Spec._SSCC.Integration
{
    [TestFixture]
    class When_Integration
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            SSCC sscc = new SSCC();
            sscc.Start();
        }

        
 

    }

}