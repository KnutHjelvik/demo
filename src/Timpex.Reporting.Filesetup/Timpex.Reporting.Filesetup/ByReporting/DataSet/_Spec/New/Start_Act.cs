﻿using Rhino.Mocks;
using Timpex.Reporting.Filesetup.ByCore;

namespace Timpex.Reporting.Filesetup.ByReporting.DataSet._Spec.New
{
    abstract class Start_Act : New_Act
    {
        protected string SourceDir = "SourceDir";
        protected string destination = "Destionation";
        protected TransferInformation TransferInformation = MockRepository.GenerateMock<TransferInformation>();
        protected AcceptedExtensions AcceptedExtensions = MockRepository.GenerateMock<AcceptedExtensions>();
        protected string[] Extensions = {"Extension"};

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            FolderSettings.Stub(x => x.GetDatasets()).Return(SourceDir);
            DirectoryImpl.Stub(x => x.CreateDataSetDirectory()).Return(destination);
            TransferInformationFactory.Stub(x => x.Create(SourceDir, destination)).Return(TransferInformation);
            AcceptedFileExtensionFactory.Stub(x => x.Create(Extensions)).Return(AcceptedExtensions);
        }

        protected override void Act()
        {
            Sut.Start();
        }
    }


}