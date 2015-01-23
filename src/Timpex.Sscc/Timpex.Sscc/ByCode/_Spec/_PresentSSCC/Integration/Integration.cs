using System;
using NUnit.Framework;

namespace Timpex.Sscc.ByCode._Spec._PresentSSCC.Integration
{
    [TestFixture]
    class When_Integration
    {

        [Test]
        public void It_Should_Present_Codes()
        {
            var sscc = PresentSSCC.New();
            var codes = sscc.PresentCodes();
            foreach (var presentableCode in codes)
            {
                Console.WriteLine("ApplicationIdentifier: "+ presentableCode.ApplicationIdentifier);
                Console.WriteLine("Identifier: "+ presentableCode.Identifier);
                Console.WriteLine("SerialNumber: "+ presentableCode.Serial);
                Console.WriteLine("Supplier: "+ presentableCode.SupplierCode);
                Console.WriteLine("CountryCode: "+ presentableCode.CountryCode);
                Console.WriteLine();
                Console.WriteLine();
            }
        }

    }

}