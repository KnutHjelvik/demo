using Rhino.Mocks;
using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.ByDeployment;
using Timpex.Reporting.Filesetup.ByReporting.DataSet;
using Timpex.Reporting.Filesetup.ByReporting.DataSource;
using Timpex.Reporting.Filesetup.ByReporting.Reports.Utv.Eng;
using Timpex.Reporting.Filesetup.BySql;
using Timpex.Reporting.Filesetup.BySsis.Batch;
using Timpex.Reporting.Filesetup.BySsis.IntegrationPacks;

namespace Timpex.Reporting.Filesetup.All.Startpoints._Spec._StartpointEnglishExtended.New
{
    abstract class Start_Act : New_Act
    {
        protected StartpointIntegrationPacks StartpointIntegrationPacks = MockRepository.GenerateMock<StartpointIntegrationPacks>();
        protected StartpointSSISBatch StartpointSsisBatch = MockRepository.GenerateMock<StartpointSSISBatch>();
        protected StartpointDataSet StartpointDataset = MockRepository.GenerateMock<StartpointDataSet>();
        protected StartpointDataSource StartpointDataSource = MockRepository.GenerateMock<StartpointDataSource>();
        protected StartpointSql StartpointSql = MockRepository.GenerateMock<StartpointSql>();
        protected StartpointDeployment StartpointDeployment = MockRepository.GenerateMock<StartpointDeployment>();
        protected StartpointReportsEngUtv StartpointReportsEngUtv = MockRepository.GenerateMock<StartpointReportsEngUtv>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            CommandHandlerContainer.Stub(x => x.Resolve<StartpointIntegrationPacks>())
                .Return(StartpointIntegrationPacks);
            CommandHandlerContainer.Stub(x => x.Resolve<StartpointSSISBatch>()).Return(StartpointSsisBatch);
            CommandHandlerContainer.Stub(x => x.Resolve<StartpointDataSet>()).Return(StartpointDataset);
            CommandHandlerContainer.Stub(x => x.Resolve<StartpointDataSource>()).Return(StartpointDataSource);
            CommandHandlerContainer.Stub(x => x.Resolve<StartpointSql>()).Return(StartpointSql);
            CommandHandlerContainer.Stub(x => x.Resolve<StartpointDeployment>()).Return(StartpointDeployment);
            CommandHandlerContainer.Stub(x => x.Resolve<StartpointReportsEngUtv>()).Return(StartpointReportsEngUtv);
        }

        protected override void Act()
        {
          Sut.Start();  
        }
    }


}