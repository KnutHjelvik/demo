using System;
using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.ByCore.Factory;
using Timpex.Reporting.Filesetup.ByCore.Folder;
using Timpex.Reporting.Filesetup.ByCore.IO;

namespace Timpex.Reporting.Filesetup.BySql
{
    public class StartpointSql:StartPoint
    {
        private FileTransferExecuter _fileTransferExecuter = FileTransferExecuter.New();
        private FolderSettings _folderSettings = FolderSettings.New();
        private DirectoryImpl _directoryImpl = DirectoryImpl.New();
        private AcceptedFileExtensionFactory _acceptedFileExtensionFactory = AcceptedFileExtensionFactory.New();
        private TransferInformationFactory _transferInformationFactory = TransferInformationFactory.New();
        private SqlScriptMerger _sqlScriptMerger = SqlScriptMerger.New();
        private AcceptedFilePrefixFactory _acceptedFilePrefixFactory = AcceptedFilePrefixFactory.New();

        public static Func<StartpointSql> New = () => new StartpointSql();
        private string _destinationUpdates;
        private string _destinationMaster;

        public StartpointSql(FileTransferExecuter fileTransferExecuter,FolderSettings folderSettings, DirectoryImpl directoryImpl,AcceptedFileExtensionFactory acceptedFileExtensionFactory, TransferInformationFactory transferInformationFactory,SqlScriptMerger sqlScriptMerger,AcceptedFilePrefixFactory acceptedFilePrefixFactory)
        {
            _fileTransferExecuter = fileTransferExecuter;
            _folderSettings = folderSettings;
            _directoryImpl = directoryImpl;
            _acceptedFileExtensionFactory = acceptedFileExtensionFactory;
            _transferInformationFactory = transferInformationFactory;
            _sqlScriptMerger = sqlScriptMerger;
            _acceptedFilePrefixFactory = acceptedFilePrefixFactory;
        }

        public virtual void Start()
        {
            MasterSql();
            UpdatesSql();
            Merge();
        }

        private void UpdatesSql()
        {
            var sourceDir = _folderSettings.GetSqlUpdates();
            _destinationUpdates = _directoryImpl.CreateSqlUpdatesDirectory();
            var transferInformation = _transferInformationFactory.Create(sourceDir, _destinationUpdates);
            var acceptedFileExtensions = _acceptedFileExtensionFactory.Create(".sql");
            var acceptedPrefix = _acceptedFilePrefixFactory.Create("Update");
            _fileTransferExecuter.Execute(transferInformation, acceptedFileExtensions,acceptedPrefix); 
        }

        private void Merge()
        {
            var path = _directoryImpl.CreateSqlRootDirectory();
            var destinationMaster = path + "/Reporting.Master + Updates.sql";
            var destinationUpdates = path + "/Reporting.Updates.sql";
            _sqlScriptMerger.Merge(_destinationMaster,_destinationUpdates,destinationMaster);
            _sqlScriptMerger.Merge(_destinationUpdates,destinationUpdates);
            _directoryImpl.Remove(_destinationMaster);
            _directoryImpl.Remove(_destinationUpdates);
        }

        private void MasterSql()
        {
            var sourceDir = _folderSettings.GetSqlMaster();
            _destinationMaster = _directoryImpl.CreateSqlMasterDirectory();
            var transferInformation = _transferInformationFactory.Create(sourceDir, _destinationMaster);
            var acceptedFileExtensions = _acceptedFileExtensionFactory.Create(".sql");
            _fileTransferExecuter.Execute(transferInformation, acceptedFileExtensions);
        }


        public StartpointSql()
        {
        }
 
    }
}