using System;
using System.Collections.Generic;
using NUnit.Framework;
using Rhino.Mocks;
using Timpex.Reporting.Filesetup.ByCore.IO;

namespace Timpex.Reporting.Filesetup.ByCore._Spec._FileTransferExecuter.New
{
    abstract class Execute_Act : New_Act
    {
        protected TransferInformation TransferInformation = MockRepository.GenerateMock<TransferInformation>();
        protected AcceptedExtensions AcceptedExtensions = MockRepository.GenerateMock<AcceptedExtensions>();

        protected string Destination = "Destination";
        protected string Source = "Source";
        protected List<FileInformation> Files = new List<FileInformation>();

        protected string info;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            TransferInformation.Stub(x => x.Destination).Return(Destination);
            TransferInformation.Stub(x => x.Source).Return(Source);
            FileExcluder.Stub(x => x.ReadAndExclude(AcceptedExtensions, Source)).Return(Files);
            info = String.Format("Files copied from location {0} to location {1}", Source, Destination);
        }

        protected override void Act()
        {
            Sut.Execute(TransferInformation,AcceptedExtensions);
        }
    }


}