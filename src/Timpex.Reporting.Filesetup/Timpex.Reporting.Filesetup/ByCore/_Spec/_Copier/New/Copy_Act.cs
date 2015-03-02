using System.Collections.Generic;
using NUnit.Framework;
using Rhino.Mocks;
using Timpex.Reporting.Filesetup.ByCore.IO;

namespace Timpex.Reporting.Filesetup.ByCore._Spec._Copier.New
{
    abstract class Copy_Act : New_Act
    {
        protected static FileInformation FileInformation1 = MockRepository.GenerateMock<FileInformation>();
        protected static FileInformation FileInformation2 = MockRepository.GenerateMock<FileInformation>();

        protected List<FileInformation> Files = new List<FileInformation>() {FileInformation1, FileInformation2};

        protected string destinationPath = "destination";
        protected string source = "source";
        protected string name = "name";
        protected string FQPath = "FQPath";

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            FileInformation1.Stub(x => x.Path).Return(source);
            FileInformation1.Stub(x => x.Name).Return(name);
            PathImpl.Stub(x => x.Combine(destinationPath, name)).Return(FQPath);
            FileImpl.Stub(x => x.MoveFile(source, FQPath));
        }

        protected override void Act()
        {
            Sut.Copy(Files,destinationPath);
        }
    }


}