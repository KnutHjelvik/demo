using System;
using NUnit.Framework;

namespace Timpex.Kata._Spec
{  
    [TestFixture]
    class AdvancedTimpexPrinterTest
    {
        

        private readonly TimpexAdvancedPrinter _sut = new TimpexAdvancedPrinter();
        private const int LENGTH = 15*15;
        private readonly string[] _result = new string[LENGTH];

        [TestFixtureSetUp]
        public void Setup()
        {
            for (int i = 0; i < LENGTH; i++)
            {
                _result[i] = _sut.Print();
                Console.WriteLine("index: " + i + " "+_result[i]);
            }
        }

        [Test]
        public void It_Should_Return_Expected()
        {
            Assert.AreEqual("1",_result[0]);
            Assert.AreEqual("2", _result[1]);
            Assert.AreEqual("tim", _result[2]);
            Assert.AreEqual("4", _result[3]);
            Assert.AreEqual("pex", _result[4]);
            Assert.AreEqual("tim 2", _result[5]);
            Assert.AreEqual("7", _result[6]);
            Assert.AreEqual("8", _result[7]);
            Assert.AreEqual("tim tim", _result[8]);
            Assert.AreEqual("pex 2", _result[9]);
            Assert.AreEqual("11", _result[10]);
            Assert.AreEqual("tim 4", _result[11]);
            Assert.AreEqual("13", _result[12]);
            Assert.AreEqual("14", _result[13]);
            Assert.AreEqual("timpex", _result[14]);
            Assert.AreEqual("16", _result[15]);
            Assert.AreEqual("17", _result[16]);
            Assert.AreEqual("tim pex", _result[17]);
            Assert.AreEqual("19", _result[18]);
            Assert.AreEqual("pex tim", _result[19]);
            Assert.AreEqual("tim tim", _result[20]);
            Assert.AreEqual("22", _result[21]);
            Assert.AreEqual("23", _result[22]);
            Assert.AreEqual("tim 7", _result[23]);
            Assert.AreEqual("pex 4", _result[24]);
            Assert.AreEqual("26", _result[25]);
            Assert.AreEqual("tim 8", _result[26]);
            Assert.AreEqual("28", _result[27]);
            Assert.AreEqual("29", _result[28]);
            Assert.AreEqual("timpex 2", _result[29]);
            Assert.AreEqual("31", _result[30]);
            Assert.AreEqual("32", _result[31]);
            Assert.AreEqual("tim tim", _result[32]);
            Assert.AreEqual("34", _result[33]);
            Assert.AreEqual("timpex timpex", _result[15*15-1]);
            Assert.AreEqual("pex timpex", _result[109]);
            Assert.AreEqual("tim timpex", _result[167]);
        }
    }
}
