using Rhino.Mocks;
using Timpex.Reporting.Filesetup.ByReporting.DataSet;
using Timpex.Reporting.Filesetup.ByReporting.DataSource;
using Timpex.Reporting.Filesetup.ByReporting.Reports.Std.Eng;
using Timpex.Reporting.Filesetup.ByReporting.Reports.Std.Nor;
using Timpex.Reporting.Filesetup.ByReporting.Reports.Utv.Eng;
using Timpex.Reporting.Filesetup.ByReporting.Reports.Utv.Nor;

namespace Timpex.Reporting.Filesetup.ByReporting.All._Spec.New
{
    abstract class Start_Act : New_Act
    {
        protected StartpointDataSet StartpointDataSet = MockRepository.GenerateMock<StartpointDataSet>();
        protected StartpointDataSource StartpointDataSource = MockRepository.GenerateMock<StartpointDataSource>();
        protected StartpointReports StartpointReports = MockRepository.GenerateMock<StartpointReports>();
        protected StartpointReportsEng StartPointReportsEng = MockRepository.GenerateMock<StartpointReportsEng>();
        protected StartpointReportsEngUtv StartPointReportsEngUtv = MockRepository.GenerateMock<StartpointReportsEngUtv>();
        protected StartpointReportsUtv StartpointReportsUtv = MockRepository.GenerateMock<StartpointReportsUtv>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            CommandHandlerContainer.Stub(x => x.Resolve<StartpointDataSet>()).Return(StartpointDataSet);
            CommandHandlerContainer.Stub(x => x.Resolve<StartpointDataSource>()).Return(StartpointDataSource);
            CommandHandlerContainer.Stub(x => x.Resolve<StartpointReports>()).Return(StartpointReports);
            CommandHandlerContainer.Stub(x => x.Resolve<StartpointReportsEng>()).Return(StartPointReportsEng);
            CommandHandlerContainer.Stub(x => x.Resolve<StartpointReportsEngUtv>()).Return(StartPointReportsEngUtv);
            CommandHandlerContainer.Stub(x => x.Resolve<StartpointReportsUtv>()).Return(StartpointReportsUtv);
        }

        protected override void Act()
        {
            Sut.Start();
        }
    }


}