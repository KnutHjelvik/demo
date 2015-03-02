using Rhino.Mocks;
using Timpex.Reporting.Filesetup.ByReporting.DataSet;
using Timpex.Reporting.Filesetup.ByReporting.DataSource;
using Timpex.Reporting.Filesetup.ByReporting.Reports.Eng;
using Timpex.Reporting.Filesetup.ByReporting.Reports.Nor;

namespace Timpex.Reporting.Filesetup.ByReporting.All._Spec.New
{
    abstract class Start_Act : New_Act
    {
        protected StartpointDataSet StartpointDataSet = MockRepository.GenerateMock<StartpointDataSet>();
        protected StartpointDataSource StartpointDataSource = MockRepository.GenerateMock<StartpointDataSource>();
        protected StartpointReports StartpointReports = MockRepository.GenerateMock<StartpointReports>();
        protected StartpointReportsEng StartPointReportsEng = MockRepository.GenerateMock<StartpointReportsEng>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            CommandHandlerContainer.Stub(x => x.Resolve<StartpointDataSet>()).Return(StartpointDataSet);
            CommandHandlerContainer.Stub(x => x.Resolve<StartpointDataSource>()).Return(StartpointDataSource);
            CommandHandlerContainer.Stub(x => x.Resolve<StartpointReports>()).Return(StartpointReports);
            CommandHandlerContainer.Stub(x => x.Resolve<StartpointReportsEng>()).Return(StartPointReportsEng);
        }

        protected override void Act()
        {
            Sut.Start();
        }
    }


}