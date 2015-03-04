using System;
using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.ByCore.Factory;
using Timpex.Reporting.Filesetup.ByCore.Folder;
using Timpex.Reporting.Filesetup.ByCore.IO;

namespace Timpex.Reporting.Filesetup.ByReporting.Reports.Utv.Nor
{
    public class StartpointReportsUtv:StartPoint
    {
        private FileTransferExecuter _fileTransferExecuter = FileTransferExecuter.New();
        private FolderSettings _folderSettings = FolderSettings.New();
        private DirectoryImpl _directoryImpl = DirectoryImpl.New();
        private AcceptedFileExtensionFactory _acceptedFileExtensionFactory = AcceptedFileExtensionFactory.New();
        private TransferInformationFactory _transferInformationFactory = TransferInformationFactory.New();
        private AcceptedFilePrefixFactory _acceptedFilePrefixFactory = AcceptedFilePrefixFactory.New();

        public static Func<StartpointReportsUtv> New = () => new StartpointReportsUtv();

        public StartpointReportsUtv(FileTransferExecuter fileTransferExecuter,FolderSettings folderSettings, DirectoryImpl directoryImpl,AcceptedFileExtensionFactory acceptedFileExtensionFactory, TransferInformationFactory transferInformationFactory,AcceptedFilePrefixFactory acceptedFilePrefixFactory)
        {
            _fileTransferExecuter = fileTransferExecuter;
            _folderSettings = folderSettings;
            _directoryImpl = directoryImpl;
            _acceptedFileExtensionFactory = acceptedFileExtensionFactory;
            _transferInformationFactory = transferInformationFactory;
            _acceptedFilePrefixFactory = acceptedFilePrefixFactory;

        }

        public virtual void Start()
        {
            var sourceDir = _folderSettings.GetNorwegianReports();
            var destination = _directoryImpl.CreateReportNorUtvDirectory();
            var transferInformation = _transferInformationFactory.Create(sourceDir, destination);
            var acceptedFileExtensions = _acceptedFileExtensionFactory.Create(".rdl");
            var acceptedPrefixes = _acceptedFilePrefixFactory.Create("STD","UTV");
            _fileTransferExecuter.Execute(transferInformation, acceptedFileExtensions,acceptedPrefixes);
        }


        public StartpointReportsUtv()
        {
        }

    
    }
}