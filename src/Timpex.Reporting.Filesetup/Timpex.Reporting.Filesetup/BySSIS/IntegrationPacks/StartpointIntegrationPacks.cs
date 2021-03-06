﻿using System;
using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.ByCore.Factory;
using Timpex.Reporting.Filesetup.ByCore.Folder;
using Timpex.Reporting.Filesetup.ByCore.IO;
using Timpex.Reporting.Filesetup.BySsis.Batch;

namespace Timpex.Reporting.Filesetup.BySsis.IntegrationPacks
{
    public class StartpointIntegrationPacks:StartPoint
    {
       private FileTransferExecuter _fileTransferExecuter = FileTransferExecuter.New();
        private FolderSettings _folderSettings = FolderSettings.New();
        private DirectoryImpl _directoryImpl = DirectoryImpl.New();
        private AcceptedFileExtensionFactory _acceptedFileExtensionFactory = AcceptedFileExtensionFactory.New();
        private TransferInformationFactory _transferInformationFactory = TransferInformationFactory.New();

        public static Func<StartpointSSISBatch> New = () => new StartpointSSISBatch();

        public StartpointIntegrationPacks(FileTransferExecuter fileTransferExecuter,FolderSettings folderSettings, DirectoryImpl directoryImpl,AcceptedFileExtensionFactory acceptedFileExtensionFactory, TransferInformationFactory transferInformationFactory)
        {
            _fileTransferExecuter = fileTransferExecuter;
            _folderSettings = folderSettings;
            _directoryImpl = directoryImpl;
            _acceptedFileExtensionFactory = acceptedFileExtensionFactory;
            _transferInformationFactory = transferInformationFactory;

        }

        public virtual void Start()
        {
            var sourceDir = _folderSettings.GetSsis();
            var destination = _directoryImpl.CreateSsisDirectory();
            var transferInformation = _transferInformationFactory.Create(sourceDir, destination);
            var acceptedFileExtensions = _acceptedFileExtensionFactory.Create(".bat",".dtsConfig",".dtsx");
            _fileTransferExecuter.Execute(transferInformation, acceptedFileExtensions);
        }


        public StartpointIntegrationPacks()
        {
        }
    }
}