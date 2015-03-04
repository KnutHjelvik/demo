using NUnit.Framework;
using Rhino.Mocks;

namespace Timpex.Reporting.Filesetup._Spec._StartpointInformation.New
{
    [TestFixture]
    class When_Start:Start_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Write_sql_Information()
        {
            ConsoleImpl.AssertWasCalled(x => x.Info("       sql  [Copies and merges all Reporting scripts]"));
        }


        [Test]
        public void It_Should_Write_Deployment_Information()
        {
            ConsoleImpl.AssertWasCalled(x => x.Info("       deployment  [copies deployment files]"));
        }

        [Test]
        public void It_Should_Write_Integration_Information()
        {
            ConsoleImpl.AssertWasCalled(x => x.Info("       integration  [Copies integration package files]"));
        }

        [Test]
        public void It_Should_Write_datasources_Information()
        {
            ConsoleImpl.AssertWasCalled(x => x.Info("       datasources  [Copies datasourcefiles files]"));
        }

        [Test]
        public void It_Should_Write_Datasets_Information()
        {
            ConsoleImpl.AssertWasCalled(x => x.Info("       datasets  [Copies dataset files]"));
        }

        [Test]
        public void It_Should_Write_Reports_Nor_Utv_Information()
        {
            ConsoleImpl.AssertWasCalled(x => x.Info("       reports_eng_utv  [Copies english extended and standard reports]"));
        }

        [Test]
        public void It_Should_Write_Reports_Nor_Std_Information()
        {
            ConsoleImpl.AssertWasCalled(x => x.Info("       reports_nor  [Copies norwegian standard reports]"));
        }

        [Test]
        public void It_Should_Write_Reports_Eng_Std_Information()
        {
            ConsoleImpl.AssertWasCalled(x => x.Info("       reports_eng  [Copies english standard reports]"));
        }

        [Test]
        public void It_Should_Write_Nor_Std_Information()
        {
            ConsoleImpl.AssertWasCalled(x => x.Info("       nor_std  [Creates a complete package with norwegian standard reports]"));
        }

        [Test]
        public void It_Should_Write_Nor_Utv_Information()
        {
            ConsoleImpl.AssertWasCalled(x => x.Info("       nor_utv  [Creates a complete package with norwegian extended reports]"));
        }

        [Test]
        public void It_Should_Write_Eng_Std_Information()
        {
            ConsoleImpl.AssertWasCalled(x => x.Info("       eng_std  [Creates a complete package with english standard reports]"));
        }

        [Test]
        public void It_Should_Write_Eng_Utv_Information()
        {
            ConsoleImpl.AssertWasCalled(x => x.Info("       eng_utv  [Creates a complete package with english extended reports]"));
        }

        [Test]
        public void It_Should_Write_Ssis_Information()
        {
            ConsoleImpl.AssertWasCalled(x => x.Info("       ssis  [Creates a complete package with all ssis files]"));
        }

        [Test]
        public void It_Should_Write_Reporting_Information()
        {
            ConsoleImpl.AssertWasCalled(x => x.Info("       reporting  [copies all reports]"));
        }

        [Test]
        public void It_Should_Write_All_Information()
        {
            ConsoleImpl.AssertWasCalled(x => x.Info("       all  [Creates a complete package]"));
        } 
    }

}