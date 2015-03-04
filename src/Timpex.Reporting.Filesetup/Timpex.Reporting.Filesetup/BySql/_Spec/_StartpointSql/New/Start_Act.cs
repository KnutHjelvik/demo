using Rhino.Mocks;
using Timpex.Reporting.Filesetup.ByCore;

namespace Timpex.Reporting.Filesetup.BySql._Spec._StartpointSql.New
{
    abstract class Start_Act : New_Act
    {
        protected string sqlSourceUpdatesPath = "sqlSourceUpdatePath";
        protected string sqlDestUpdatesPath = "sqlDestUpdatePath";
        protected string sqlRootPath = "sqlRootPath";
        protected string sqlSourceMasterPath = "sqlSourceMasterPath";
        protected string sqlDestMasterPath = "sqlDestMasterPath";
        protected string sqlUpdates = "/Reporting.Updates.sql";
        protected string sqlMaster = "/Reporting.Master + Updates.sql";

        protected TransferInformation TransferInformation = MockRepository.GenerateMock<TransferInformation>();
        protected AcceptedExtensions AcceptedExtensions = MockRepository.GenerateMock<AcceptedExtensions>();
        protected AcceptedPrefix AcceptedPrefix = MockRepository.GenerateMock<AcceptedPrefix>();
        protected string[] Extensions = { "Extension" };
        protected string[] Prefixes = { "Prefix" };

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            FolderSettings.Stub(x => x.GetSqlUpdates()).Return(sqlSourceUpdatesPath);
            FolderSettings.Stub(x => x.GetSqlMaster()).Return(sqlSourceMasterPath);
            DirectoryImpl.Stub(x => x.CreateSqlMasterDirectory()).Return(sqlDestMasterPath);
            DirectoryImpl.Stub(x => x.CreateSqlUpdatesDirectory()).Return(sqlDestUpdatesPath);
            DirectoryImpl.Stub(x => x.CreateSqlRootDirectory()).Return(sqlRootPath);
            TransferInformationFactory.Stub(x => x.Create(sqlSourceMasterPath, sqlDestMasterPath))
                .Return(TransferInformation);
            AcceptedFileExtensionFactory.Stub(x => x.Create(Extensions)).Return(AcceptedExtensions);
            AcceptedFilePrefixFactory.Stub(x => x.Create(Prefixes)).Return(AcceptedPrefix);
        }

        protected override void Act()
        {
            Sut.Start();
        }
    }


}