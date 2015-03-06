using Rhino.Mocks;
using Timpex.Reporting.Filesetup.ByDeployment;
using Timpex.Reporting.Filesetup.ByReporting.DataSet;
using Timpex.Reporting.Filesetup.ByReporting.DataSource;
using Timpex.Reporting.Filesetup.ByReporting.Reports.Std.Eng;
using Timpex.Reporting.Filesetup.ByReporting.Reports.Std.Nor;
using Timpex.Reporting.Filesetup.ByReporting.Reports.Utv.Eng;
using Timpex.Reporting.Filesetup.ByReporting.Reports.Utv.Nor;
using Timpex.Reporting.Filesetup.BySql;
using Timpex.Reporting.Filesetup.BySsis.Batch;
using Timpex.Reporting.Filesetup.BySsis.IntegrationPacks;

namespace Timpex.Reporting.Filesetup.All.Startpoints._Spec._StartpointAll.New
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
        protected StartpointReportsEng StartpointReportsEng = MockRepository.GenerateMock<StartpointReportsEng>();
        protected StartpointReports StartpointReports = MockRepository.GenerateMock<StartpointReports>();
        protected StartpointReportsUtv StartpointReportsUtv = MockRepository.GenerateMock<StartpointReportsUtv>();
        protected StartpointCompression StartpointCompression = MockRepository.GenerateMock<StartpointCompression>();


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
            CommandHandlerContainer.Stub(x => x.Resolve<StartpointReportsEng>()).Return(StartpointReportsEng);
            CommandHandlerContainer.Stub(x => x.Resolve<StartpointReports>()).Return(StartpointReports);
            CommandHandlerContainer.Stub(x => x.Resolve<StartpointReportsUtv>()).Return(StartpointReportsUtv);
            CommandHandlerContainer.Stub(x => x.Resolve<StartpointCompression>()).Return(StartpointCompression);
        }

        protected override void Act()
        {
          Sut.Start();  
        }
    }


}