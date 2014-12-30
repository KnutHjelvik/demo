using System;
using NUnit.Framework;

namespace Timpex.Kata.Advanced._Spec._Timpex.New.IntegrationTests
{
    [TestFixture]
    public class When_Massprint
    {

        private Timpex timpex = new Timpex();

        [TestFixtureSetUp]
        public void Setup()
        {
            timpex = new Timpex();
        }

        [Test]
        public void It_Should_Print_Correct()
        {
            for (int i = 0; i < 400; i++)
            {
                Console.WriteLine(timpex.Print());
            }
            
       
        }

         

    }

}