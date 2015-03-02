﻿using Rhino.Mocks;
using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.ByCore.Factory;
using Timpex.Reporting.Filesetup.ByCore.Folder;
using Timpex.Reporting.Filesetup.ByCore.IO;
using Timpex.Reporting.Filesetup.ByReporting.Reports.Nor;

namespace Timpex.Reporting.Filesetup.BySSIS.Batch._Spec
{
    abstract class New_Act : Base_Act
    {
        protected StartpointSSISBatch Sut;
        protected FileTransferExecuter FileTransferExecuter = MockRepository.GenerateMock<FileTransferExecuter>();
        protected FolderSettings FolderSettings = MockRepository.GenerateMock<FolderSettings>();
        protected DirectoryImpl DirectoryImpl = MockRepository.GenerateMock<DirectoryImpl>();
        protected AcceptedFileExtensionFactory AcceptedFileExtensionFactory = MockRepository.GenerateMock<AcceptedFileExtensionFactory>();
        protected TransferInformationFactory TransferInformationFactory = MockRepository.GenerateMock<TransferInformationFactory>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new StartpointSSISBatch(FileTransferExecuter,FolderSettings,DirectoryImpl,AcceptedFileExtensionFactory,TransferInformationFactory);
        }
    }


}