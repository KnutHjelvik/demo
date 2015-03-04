using Rhino.Mocks;
using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.ByCore.Factory;
using Timpex.Reporting.Filesetup.ByCore.Folder;
using Timpex.Reporting.Filesetup.ByCore.IO;
using Timpex.Reporting.Filesetup.ByReporting.DataSet;

namespace Timpex.Reporting.Filesetup.ByDeployment._Spec._StartpointDeployment
{
    abstract class New_Act : Base_Act
    {
        protected StartpointDeployment Sut;
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
            Sut = new StartpointDeployment(FileTransferExecuter,FolderSettings,DirectoryImpl,AcceptedFileExtensionFactory,TransferInformationFactory);
        }
    }


}