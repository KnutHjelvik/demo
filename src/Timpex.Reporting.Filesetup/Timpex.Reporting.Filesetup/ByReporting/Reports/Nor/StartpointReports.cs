using System;
using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.ByCore.Factory;
using Timpex.Reporting.Filesetup.ByCore.Folder;
using Timpex.Reporting.Filesetup.ByCore.IO;


namespace Timpex.Reporting.Filesetup.ByReporting.Reports.Nor
{
    public class StartpointReports:StartPoint
    {
        private FileTransferExecuter _fileTransferExecuter = FileTransferExecuter.New();
        private FolderSettings _folderSettings = FolderSettings.New();
        private DirectoryImpl _directoryImpl = DirectoryImpl.New();
        private AcceptedFileExtensionFactory _acceptedFileExtensionFactory = AcceptedFileExtensionFactory.New();
        private TransferInformationFactory _transferInformationFactory = TransferInformationFactory.New();
        private AcceptedFilePrefixFactory _acceptedFilePrefixFactory = AcceptedFilePrefixFactory.New();

        public static Func<StartpointReports> New = () => new StartpointReports();

                public StartpointReports(FileTransferExecuter fileTransferExecuter,FolderSettings folderSettings, DirectoryImpl directoryImpl,AcceptedFileExtensionFactory acceptedFileExtensionFactory, TransferInformationFactory transferInformationFactory,AcceptedFilePrefixFactory acceptedFilePrefixFactory)
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
            var destination = _directoryImpl.CreateReportsDirectory();
            var transferInformation = _transferInformationFactory.Create(sourceDir, destination);
            var acceptedFileExtensions = _acceptedFileExtensionFactory.Create(".rdl");
            var acceptedPrefixes = _acceptedFilePrefixFactory.Create("STD");
            _fileTransferExecuter.Execute(transferInformation, acceptedFileExtensions,acceptedPrefixes);
        }


        public StartpointReports()
        {
        }

    
    }
}