using System;
using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.ByCore.Factory;
using Timpex.Reporting.Filesetup.ByCore.Folder;
using Timpex.Reporting.Filesetup.ByCore.IO;

namespace Timpex.Reporting.Filesetup.ByDeployment
{
    public class StartpointDeployment:StartPoint
    {
        private FileTransferExecuter _fileTransferExecuter = FileTransferExecuter.New();
        private FolderSettings _folderSettings = FolderSettings.New();
        private DirectoryImpl _directoryImpl = DirectoryImpl.New();
        private AcceptedFileExtensionFactory _acceptedFileExtensionFactory = AcceptedFileExtensionFactory.New();
        private TransferInformationFactory _transferInformationFactory = TransferInformationFactory.New();

        public static Func<StartpointDeployment> New = () => new StartpointDeployment();

        public StartpointDeployment(FileTransferExecuter fileTransferExecuter,FolderSettings folderSettings, DirectoryImpl directoryImpl,AcceptedFileExtensionFactory acceptedFileExtensionFactory, TransferInformationFactory transferInformationFactory)
        {
            _fileTransferExecuter = fileTransferExecuter;
            _folderSettings = folderSettings;
            _directoryImpl = directoryImpl;
            _acceptedFileExtensionFactory = acceptedFileExtensionFactory;
            _transferInformationFactory = transferInformationFactory;

        }

        public virtual void Start()
        {
            var sourceDir = _folderSettings.GetDeploymentScripts();
            var destination = _directoryImpl.CreateRootDirectory();
            var transferInformation = _transferInformationFactory.Create(sourceDir, destination);
            var acceptedFileExtensions = _acceptedFileExtensionFactory.Create(".bat",".rss");
            _fileTransferExecuter.Execute(transferInformation, acceptedFileExtensions);
        }


        public StartpointDeployment()
        {
        }

    
    }
}